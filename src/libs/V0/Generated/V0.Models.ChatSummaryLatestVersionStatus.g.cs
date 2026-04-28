
#nullable enable

namespace V0
{
    /// <summary>
    /// The current status of the version generation process.
    /// </summary>
    public enum ChatSummaryLatestVersionStatus
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
    public static class ChatSummaryLatestVersionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSummaryLatestVersionStatus value)
        {
            return value switch
            {
                ChatSummaryLatestVersionStatus.Completed => "completed",
                ChatSummaryLatestVersionStatus.Failed => "failed",
                ChatSummaryLatestVersionStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSummaryLatestVersionStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ChatSummaryLatestVersionStatus.Completed,
                "failed" => ChatSummaryLatestVersionStatus.Failed,
                "pending" => ChatSummaryLatestVersionStatus.Pending,
                _ => null,
            };
        }
    }
}