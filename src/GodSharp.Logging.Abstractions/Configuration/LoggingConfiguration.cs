namespace GodSharp.Logging.Abstractions
{
    /// <summary>
    /// Log configuration.
    /// </summary>
    public class LoggingConfiguration
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ILogging"/> is available.
        /// </summary>
        /// <value>
        ///   <c>true</c> if available; otherwise, <c>false</c>.
        /// </value>
        public static bool Available { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [queue enable].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [queue enable]; otherwise, <c>false</c>.
        /// </value>
        public static bool QueueEnable { get; set; } = true;

        /// <summary>
        /// Gets or sets the output level.
        /// </summary>
        /// <value>
        /// The output level.
        /// </value>
        public static LoggingOutputLevel OutputLevel { get; set; } = LoggingOutputLevel.All;
    }
}
