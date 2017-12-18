using System;
using GodSharp.Logging.Abstractions;
using NLog;

namespace GodSharp.Logging
{
    /// <summary>
    /// Nlog for <see cref="GodSharp.Logging.Abstractions.Logging" />.
    /// </summary>
    /// <seealso cref="GodSharp.Logging.Abstractions.Logging" />
    public sealed class NLogging: Abstractions.Logging
    {
        private readonly Logger Logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="NLogging"/> class.
        /// </summary>
        public NLogging() => Logger = LogManager.GetLogger(GetType().FullName);

        /// <summary>
        /// Initializes a new instance of the <see cref="NLogging"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public NLogging(string name) => Logger = LogManager.GetLogger(name);
        
        /// <summary>
        /// Writes the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="type">The type.</param>
        /// <param name="exception">The exception.</param>
        protected override void WriteInvoke(string log, LoggingLevel type, Exception exception = null)
        {
            LogLevel level = LogLevel.Info;

            switch (type)
            {
                case LoggingLevel.Debug:
                    level = LogLevel.Debug;
                    break;
                case LoggingLevel.Info:
                    level = LogLevel.Info;
                    break;
                case LoggingLevel.Warn:
                    level = LogLevel.Warn;
                    break;
                case LoggingLevel.Error:
                    level = LogLevel.Error;
                    break;
                case LoggingLevel.Fatal:
                    level = LogLevel.Fatal;
                    break;
            }

            this.Logger.Log(level, exception, log);
        }
    }
}
