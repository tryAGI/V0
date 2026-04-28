
#nullable enable

namespace V0
{
    /// <summary>
    /// Output stream type.
    /// </summary>
    public enum DeploymentsFindLogsResponseLogType
    {
        /// <summary>
        /// 
        /// </summary>
        Stderr,
        /// <summary>
        /// 
        /// </summary>
        Stdout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentsFindLogsResponseLogTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentsFindLogsResponseLogType value)
        {
            return value switch
            {
                DeploymentsFindLogsResponseLogType.Stderr => "stderr",
                DeploymentsFindLogsResponseLogType.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentsFindLogsResponseLogType? ToEnum(string value)
        {
            return value switch
            {
                "stderr" => DeploymentsFindLogsResponseLogType.Stderr,
                "stdout" => DeploymentsFindLogsResponseLogType.Stdout,
                _ => null,
            };
        }
    }
}