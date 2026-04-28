
#nullable enable

namespace V0
{
    /// <summary>
    /// Defines the visibility of the chat—private, team-only, or public.
    /// </summary>
    public enum ProjectDetailChatPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        TeamEdit,
        /// <summary>
        /// 
        /// </summary>
        Unlisted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectDetailChatPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectDetailChatPrivacy value)
        {
            return value switch
            {
                ProjectDetailChatPrivacy.Private => "private",
                ProjectDetailChatPrivacy.Public => "public",
                ProjectDetailChatPrivacy.Team => "team",
                ProjectDetailChatPrivacy.TeamEdit => "team-edit",
                ProjectDetailChatPrivacy.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectDetailChatPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ProjectDetailChatPrivacy.Private,
                "public" => ProjectDetailChatPrivacy.Public,
                "team" => ProjectDetailChatPrivacy.Team,
                "team-edit" => ProjectDetailChatPrivacy.TeamEdit,
                "unlisted" => ProjectDetailChatPrivacy.Unlisted,
                _ => null,
            };
        }
    }
}