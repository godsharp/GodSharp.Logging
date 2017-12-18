namespace GodSharp.Logging.Abstractions
{
    public class LoggingQueueRunner
    {
        private static readonly LoggingQueueRunnerInternal runner;

        private static readonly object _lock = new object();

        /// <summary>
        /// Initializes the <see cref="LoggingQueueRunner"/> class.
        /// </summary>
        static LoggingQueueRunner()
        {
            if (runner==null)
            {
                lock (_lock)
                {
                    if (runner == null)
                    {
                        runner = new LoggingQueueRunnerInternal();
                    }
                } 
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="LoggingQueueRunner"/> is running.
        /// </summary>
        /// <value>
        ///   <c>true</c> if running; otherwise, <c>false</c>.
        /// </value>
        public static bool Running => runner.Running;

        /// <summary>
        /// Enqueues the specified body.
        /// </summary>
        /// <param name="body">The body.</param>
        public static void Enqueue(LoggingBody body)
        {
            lock (_lock)
            {
                runner.Enqueue(body);
            }
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public static void Start()
        {
            lock (_lock)
            {
                runner.Start();
            }
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        public static void Stop()
        {
            lock (_lock)
            {
                runner.Stop();
            }
        }
    }
}