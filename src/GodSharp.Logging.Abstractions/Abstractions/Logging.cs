using System;

namespace GodSharp.Logging.Abstractions
{
    /// <summary>
    /// Log <see cref="abstract"/> class.
    /// </summary>
    /// <seealso cref="GodSharp.Logging.Abstractions.ILogging" />
    public abstract class Logging : ILogging
    {
        ///// <summary>
        ///// Initializes a new instance of the <see cref="Logging"/> class.
        ///// </summary>
        //public Logging() { }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="Logging"/> class.
        ///// </summary>
        ///// <param name="name">The name.</param>
        //public Logging(string name) { }

        /// <summary>
        /// Debugs the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        public void Debug(string log, Exception exception = null) { Write(log, LoggingLevel.Debug, exception); }

        /// <summary>
        /// Errors the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        public void Error(string log, Exception exception = null) { Write(log, LoggingLevel.Error, exception); }

        /// <summary>
        /// Fatals the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        public void Fatal(string log, Exception exception = null) { Write(log, LoggingLevel.Debug, exception); }

        /// <summary>
        /// Informations the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        public void Info(string log, Exception exception = null) { Write(log, LoggingLevel.Info, exception); }

        /// <summary>
        /// Warns the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        public void Warn(string log, Exception exception = null) { Write(log, LoggingLevel.Warn, exception); }

        /// <summary>
        /// Writes the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="type">The type.</param>
        /// <param name="exception">The exception.</param>
        public void Write(string log, LoggingLevel type, Exception exception = null)
        {
            /// logging don't available
            if (!LoggingConfiguration.Available)
            {
                return;
            }

            /// logging output level is <see cref="LoggingOutputLevel.None"/>,or <param name="type"/> not equal, or <param name="type"/> more than.
            if (((int)LoggingConfiguration.OutputLevel & (int)type) == 0)
            {
                return;
            }

            /// queue disabled
            if (!LoggingConfiguration.QueueEnable)
            {
                WriteInvoke(log, type, exception);
                return;
            }

            /// queue enabled
            if (!LoggingQueueRunner.Running)
            {
                LoggingQueueRunner.SetExecutor(Write);

                while (!LoggingQueueRunner.Running)
                {
                    LoggingQueueRunner.Start();
                }
            }
            
            LoggingQueueRunner.Enqueue(new LoggingBody(log, type, exception));
        }

        /// <summary>
        /// Writes the specified body.
        /// </summary>
        /// <param name="body">The body.</param>
        private void Write(LoggingBody body)
        {
            WriteInvoke(body.Content, body.Level, body.Exception);
        }

        /// <summary>
        /// Writes the invoke.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="type">The type.</param>
        /// <param name="exception">The exception.</param>
        protected abstract void WriteInvoke(string log, LoggingLevel type, Exception exception = null);
    }
}