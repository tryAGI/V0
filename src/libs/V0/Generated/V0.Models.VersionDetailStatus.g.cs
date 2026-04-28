
#nullable enable

namespace V0
{
    /// <summary>
    /// The current status of the version generation process.
    /// </summary>
    public enum VersionDetailStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VersionDetailStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VersionDetailStatus value)
        {
            return value switch
            {
                VersionDetailStatus.Completed => "completed",
                VersionDetailStatus.Failed => "failed",
                VersionDetailStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VersionDetailStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => VersionDetailStatus.Completed,
                "failed" => VersionDetailStatus.Failed,
                "pending" => VersionDetailStatus.Pending,
                _ => null,
            };
        }
    }
}