namespace GodSharp.Logging.Abstractions
{
    /// <summary>
    /// Log level
    /// </summary>
    public enum LoggingLevel
    {
        /// <summary>
        /// The debug
        /// </summary>
        Debug = 1,
        /// <summary>
        /// The information
        /// </summary>
        Info = 2,
        /// <summary>
        /// The warn
        /// </summary>
        Warn = 4,
        /// <summary>
        /// The error
        /// </summary>
        Error = 8,
        /// <summary>
        /// The fatal
        /// </summary>
        Fatal = 16
    }
}
