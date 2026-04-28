
#nullable enable

namespace V0
{
    /// <summary>
    /// Defines the visibility of the chat—private, team-only, or public.
    /// </summary>
    public enum ChatDetailPrivacy
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
    public static class ChatDetailPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatDetailPrivacy value)
        {
            return value switch
            {
                ChatDetailPrivacy.Private => "private",
                ChatDetailPrivacy.Public => "public",
                ChatDetailPrivacy.Team => "team",
                ChatDetailPrivacy.TeamEdit => "team-edit",
                ChatDetailPrivacy.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatDetailPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ChatDetailPrivacy.Private,
                "public" => ChatDetailPrivacy.Public,
                "team" => ChatDetailPrivacy.Team,
                "team-edit" => ChatDetailPrivacy.TeamEdit,
                "unlisted" => ChatDetailPrivacy.Unlisted,
                _ => null,
            };
        }
    }
}