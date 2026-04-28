
#nullable enable

namespace V0
{
    /// <summary>
    /// The current status of the version generation process.
    /// </summary>
    public enum ProjectDetailChatLatestVersionStatus
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
    public static class ProjectDetailChatLatestVersionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectDetailChatLatestVersionStatus value)
        {
            return value switch
            {
                ProjectDetailChatLatestVersionStatus.Completed => "completed",
                ProjectDetailChatLatestVersionStatus.Failed => "failed",
                ProjectDetailChatLatestVersionStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectDetailChatLatestVersionStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ProjectDetailChatLatestVersionStatus.Completed,
                "failed" => ProjectDetailChatLatestVersionStatus.Failed,
                "pending" => ProjectDetailChatLatestVersionStatus.Pending,
                _ => null,
            };
        }
    }
}