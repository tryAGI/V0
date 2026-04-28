
#nullable enable

namespace V0
{
    /// <summary>
    /// The privacy setting for the project - either private or team.
    /// </summary>
    public enum ProjectSummaryPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSummaryPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSummaryPrivacy value)
        {
            return value switch
            {
                ProjectSummaryPrivacy.Private => "private",
                ProjectSummaryPrivacy.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSummaryPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ProjectSummaryPrivacy.Private,
                "team" => ProjectSummaryPrivacy.Team,
                _ => null,
            };
        }
    }
}