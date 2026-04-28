
#nullable enable

namespace V0
{
    /// <summary>
    /// The privacy setting for the project. For user accounts, this is always "private". For team/enterprise accounts, this can be either "private" or "team".
    /// </summary>
    public enum ProjectsCreateRequestPrivacy
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
    public static class ProjectsCreateRequestPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsCreateRequestPrivacy value)
        {
            return value switch
            {
                ProjectsCreateRequestPrivacy.Private => "private",
                ProjectsCreateRequestPrivacy.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsCreateRequestPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ProjectsCreateRequestPrivacy.Private,
                "team" => ProjectsCreateRequestPrivacy.Team,
                _ => null,
            };
        }
    }
}