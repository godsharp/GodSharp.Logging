using System;
using System.Collections.Generic;
using System.Threading;

namespace GodSharp.Logging.Abstractions
{
    /// <summary>
    /// Logging <see cref="Queue{LoggingBody}"/> runner internal object.
    /// </summary>
    internal class LoggingQueueRunnerInternal
    {
        private object _lock = new object();

        /// <summary>
        /// The que
        /// </summary>
        private Queue<LoggingBody> queue;

        /// <summary>
        /// The mre
        /// </summary>
        private ManualResetEvent me;

        /// <summary>
        /// The thread.
        /// </summary>
        private Thread thread;

        /// <summary>
        /// The stopping flag.
        /// </summary>
        private bool stopping;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="LoggingQueueRunner"/> is running.
        /// </summary>
        /// <value>
        ///   <c>true</c> if running; otherwise, <c>false</c>.
        /// </value>
        public bool Running { get; set; }

        /// <summary>
        /// Gets the queue count.
        /// </summary>
        /// <value>
        /// The queue count.
        /// </value>
        public int QueueCount => queue.Count;

        /// <summary>
        /// Gets or sets the executor.
        /// </summary>
        /// <value>
        /// The executor.
        /// </value>
        public Action<LoggingBody> Executor { get; set; }

        /// <summary>
        /// The on exception
        /// </summary>
        public Action<Exception> OnException { get; set; }

        /// <summary>
        /// Enqueues the specified body.
        /// </summary>
        /// <param name="body">The body.</param>
        public void Enqueue(LoggingBody body)
        {
            lock (_lock)
            {
                queue.Enqueue(body);
                me.Set();
            }
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {
            if (thread?.IsAlive==true)
            {
                return;
            }
            
            queue = new Queue<LoggingBody>();
            me = new ManualResetEvent(false);
            
            if (thread==null || thread.IsAlive==false)
            {
                thread = new Thread(Loop) {IsBackground = true};
            }

            thread.Start();
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void Stop()
        {
            stopping = true;
            me.Set();
        }

        /// <summary>
        /// Loop write log
        /// </summary>
        private void Loop()
        {
            Running = true;
            stopping = false;
            
            // ReSharper disable once TooWideLocalVariableScope
            LoggingBody body;

            while (Running && Running)
            {
                me.WaitOne();

                lock (_lock)
                {
                    do
                    {
                        try
                        {
                            body = queue.Dequeue();

                            Executor.Invoke(body);
                        }
                        catch (Exception ex)
                        {
                            OnException?.Invoke(ex);
                        }

                    } while (queue.Count > 0);
                }

                me.Reset();

                Thread.Sleep(10);
            }

            Running = false;
            stopping = false;
            thread = null;
        }
    }
}