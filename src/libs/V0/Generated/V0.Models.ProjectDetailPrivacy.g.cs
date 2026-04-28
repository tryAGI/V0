
#nullable enable

namespace V0
{
    /// <summary>
    /// The privacy setting for the project - either private or team.
    /// </summary>
    public enum ProjectDetailPrivacy
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
    public static class ProjectDetailPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectDetailPrivacy value)
        {
            return value switch
            {
                ProjectDetailPrivacy.Private => "private",
                ProjectDetailPrivacy.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectDetailPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ProjectDetailPrivacy.Private,
                "team" => ProjectDetailPrivacy.Team,
                _ => null,
            };
        }
    }
}