
#nullable enable

namespace V0
{
    /// <summary>
    /// The current status of the version generation process.
    /// </summary>
    public enum ChatsFindResponseDataItemLatestVersionStatus
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
    public static class ChatsFindResponseDataItemLatestVersionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsFindResponseDataItemLatestVersionStatus value)
        {
            return value switch
            {
                ChatsFindResponseDataItemLatestVersionStatus.Completed => "completed",
                ChatsFindResponseDataItemLatestVersionStatus.Failed => "failed",
                ChatsFindResponseDataItemLatestVersionStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsFindResponseDataItemLatestVersionStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ChatsFindResponseDataItemLatestVersionStatus.Completed,
                "failed" => ChatsFindResponseDataItemLatestVersionStatus.Failed,
                "pending" => ChatsFindResponseDataItemLatestVersionStatus.Pending,
                _ => null,
            };
        }
    }
}