
#nullable enable

namespace V0
{
    /// <summary>
    /// The current status of the version generation process.
    /// </summary>
    public enum ChatDetailLatestVersionStatus
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
    public static class ChatDetailLatestVersionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatDetailLatestVersionStatus value)
        {
            return value switch
            {
                ChatDetailLatestVersionStatus.Completed => "completed",
                ChatDetailLatestVersionStatus.Failed => "failed",
                ChatDetailLatestVersionStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatDetailLatestVersionStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ChatDetailLatestVersionStatus.Completed,
                "failed" => ChatDetailLatestVersionStatus.Failed,
                "pending" => ChatDetailLatestVersionStatus.Pending,
                _ => null,
            };
        }
    }
}