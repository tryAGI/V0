
#nullable enable

namespace V0
{
    /// <summary>
    /// Controls the visibility of the chat. Defines whether the chat is private, shared with a team, or publicly accessible.<br/>
    /// Default Value: private
    /// </summary>
    public enum ChatsInitRequestChatPrivacy
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
    public static class ChatsInitRequestChatPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsInitRequestChatPrivacy value)
        {
            return value switch
            {
                ChatsInitRequestChatPrivacy.Private => "private",
                ChatsInitRequestChatPrivacy.Public => "public",
                ChatsInitRequestChatPrivacy.Team => "team",
                ChatsInitRequestChatPrivacy.TeamEdit => "team-edit",
                ChatsInitRequestChatPrivacy.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsInitRequestChatPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ChatsInitRequestChatPrivacy.Private,
                "public" => ChatsInitRequestChatPrivacy.Public,
                "team" => ChatsInitRequestChatPrivacy.Team,
                "team-edit" => ChatsInitRequestChatPrivacy.TeamEdit,
                "unlisted" => ChatsInitRequestChatPrivacy.Unlisted,
                _ => null,
            };
        }
    }
}