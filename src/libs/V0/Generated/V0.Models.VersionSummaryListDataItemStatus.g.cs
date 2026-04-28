
#nullable enable

namespace V0
{
    /// <summary>
    /// The current status of the version generation process.
    /// </summary>
    public enum VersionSummaryListDataItemStatus
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
    public static class VersionSummaryListDataItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VersionSummaryListDataItemStatus value)
        {
            return value switch
            {
                VersionSummaryListDataItemStatus.Completed => "completed",
                VersionSummaryListDataItemStatus.Failed => "failed",
                VersionSummaryListDataItemStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VersionSummaryListDataItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => VersionSummaryListDataItemStatus.Completed,
                "failed" => VersionSummaryListDataItemStatus.Failed,
                "pending" => VersionSummaryListDataItemStatus.Pending,
                _ => null,
            };
        }
    }
}