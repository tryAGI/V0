
#nullable enable

namespace V0
{
    /// <summary>
    /// Log severity level.<br/>
    /// Default Value: info
    /// </summary>
    public enum DeploymentsFindLogsResponseLogLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentsFindLogsResponseLogLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentsFindLogsResponseLogLevel value)
        {
            return value switch
            {
                DeploymentsFindLogsResponseLogLevel.Error => "error",
                DeploymentsFindLogsResponseLogLevel.Info => "info",
                DeploymentsFindLogsResponseLogLevel.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentsFindLogsResponseLogLevel? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeploymentsFindLogsResponseLogLevel.Error,
                "info" => DeploymentsFindLogsResponseLogLevel.Info,
                "warning" => DeploymentsFindLogsResponseLogLevel.Warning,
                _ => null,
            };
        }
    }
}