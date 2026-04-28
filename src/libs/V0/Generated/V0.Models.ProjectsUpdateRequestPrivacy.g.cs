
#nullable enable

namespace V0
{
    /// <summary>
    /// The privacy setting for the project. For user accounts, this must be "private". For team/enterprise accounts, this can be either "private" or "team".
    /// </summary>
    public enum ProjectsUpdateRequestPrivacy
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
    public static class ProjectsUpdateRequestPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsUpdateRequestPrivacy value)
        {
            return value switch
            {
                ProjectsUpdateRequestPrivacy.Private => "private",
                ProjectsUpdateRequestPrivacy.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsUpdateRequestPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ProjectsUpdateRequestPrivacy.Private,
                "team" => ProjectsUpdateRequestPrivacy.Team,
                _ => null,
            };
        }
    }
}