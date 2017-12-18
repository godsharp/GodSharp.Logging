namespace GodSharp.Logging.Abstractions
{
    /// <summary>
    /// The log ouput level.
    /// </summary>
    public enum LoggingOutputLevel
    {
        /// <summary>
        /// The none
        /// </summary>
        None = 0,

        /// <summary>
        /// The debug
        /// </summary>
        DebugOnly = 1,
        /// <summary>
        /// The information
        /// </summary>
        InfoOnly = 2,
        /// <summary>
        /// The warn
        /// </summary>
        WarnOnly = 4,
        /// <summary>
        /// The error
        /// </summary>
        ErrorOnly = 8,
        /// <summary>
        /// The fatal
        /// </summary>
        FatalOnly = 16,

        /// <summary>
        /// The debug
        /// </summary>
        Debug = DebugOnly,
        /// <summary>
        /// The information
        /// </summary>
        Info = DebugOnly | InfoOnly,
        /// <summary>
        /// The warn
        /// </summary>
        Warn = DebugOnly | InfoOnly | WarnOnly,
        /// <summary>
        /// The error
        /// </summary>
        Error = DebugOnly | InfoOnly | WarnOnly | ErrorOnly,
        /// <summary>
        /// The fatal
        /// </summary>
        Fatal = DebugOnly | InfoOnly | WarnOnly | ErrorOnly | FatalOnly,
        /// <summary>
        /// All
        /// </summary>
        All = Fatal
    }
}
