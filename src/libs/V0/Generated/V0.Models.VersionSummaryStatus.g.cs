
#nullable enable

namespace V0
{
    /// <summary>
    /// The current status of the version generation process.
    /// </summary>
    public enum VersionSummaryStatus
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
    public static class VersionSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VersionSummaryStatus value)
        {
            return value switch
            {
                VersionSummaryStatus.Completed => "completed",
                VersionSummaryStatus.Failed => "failed",
                VersionSummaryStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VersionSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => VersionSummaryStatus.Completed,
                "failed" => VersionSummaryStatus.Failed,
                "pending" => VersionSummaryStatus.Pending,
                _ => null,
            };
        }
    }
}