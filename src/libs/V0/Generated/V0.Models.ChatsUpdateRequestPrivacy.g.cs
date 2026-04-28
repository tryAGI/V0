
#nullable enable

namespace V0
{
    /// <summary>
    /// Sets the privacy level of the chat.
    /// </summary>
    public enum ChatsUpdateRequestPrivacy
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
    public static class ChatsUpdateRequestPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsUpdateRequestPrivacy value)
        {
            return value switch
            {
                ChatsUpdateRequestPrivacy.Private => "private",
                ChatsUpdateRequestPrivacy.Public => "public",
                ChatsUpdateRequestPrivacy.Team => "team",
                ChatsUpdateRequestPrivacy.TeamEdit => "team-edit",
                ChatsUpdateRequestPrivacy.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsUpdateRequestPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ChatsUpdateRequestPrivacy.Private,
                "public" => ChatsUpdateRequestPrivacy.Public,
                "team" => ChatsUpdateRequestPrivacy.Team,
                "team-edit" => ChatsUpdateRequestPrivacy.TeamEdit,
                "unlisted" => ChatsUpdateRequestPrivacy.Unlisted,
                _ => null,
            };
        }
    }
}