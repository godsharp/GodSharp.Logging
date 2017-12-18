using System;

namespace GodSharp.Logging.Abstractions
{
    /// <summary>
    /// The <see cref="ILogging"/> interface.
    /// </summary>
    public interface ILogging
    {
        /// <summary>
        /// Debugs the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        void Debug(string log, Exception exception = null);

        /// <summary>
        /// Informations the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        void Info(string log, Exception exception = null);

        /// <summary>
        /// Warns the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        void Warn(string log, Exception exception = null);

        /// <summary>
        /// Errors the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        void Error(string log, Exception exception = null);

        /// <summary>
        /// Fatals the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        void Fatal(string log, Exception exception = null);

        /// <summary>
        /// Writes the specified log.
        /// </summary>
        /// <param name="log">The log.</param>
        /// <param name="type">The type.</param>
        /// <param name="exception">The exception.</param>
        void Write(string log, LoggingLevel type, Exception exception = null);
    }
}
