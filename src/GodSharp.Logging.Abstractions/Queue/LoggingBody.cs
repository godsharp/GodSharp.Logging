using System;

namespace GodSharp.Logging.Abstractions
{
    public struct LoggingBody
    {
        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        public LoggingLevel Level { get; set; }

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public Exception Exception { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingBody"/> struct.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <param name="level">The level.</param>
        /// <param name="exception">The exception.</param>
        public LoggingBody(string content,LoggingLevel level, Exception exception)
        {
            Content = content;
            Level = level;
            Exception = exception;
        }
    }
}
