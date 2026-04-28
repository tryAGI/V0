
#nullable enable

namespace V0
{
    /// <summary>
    /// Determines the privacy setting of the chat. This can control whether the chat is visible only to the user, to team members, or is public.<br/>
    /// Default Value: private
    /// </summary>
    public enum ChatsCreateRequestChatPrivacy
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
    public static class ChatsCreateRequestChatPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsCreateRequestChatPrivacy value)
        {
            return value switch
            {
                ChatsCreateRequestChatPrivacy.Private => "private",
                ChatsCreateRequestChatPrivacy.Public => "public",
                ChatsCreateRequestChatPrivacy.Team => "team",
                ChatsCreateRequestChatPrivacy.TeamEdit => "team-edit",
                ChatsCreateRequestChatPrivacy.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsCreateRequestChatPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ChatsCreateRequestChatPrivacy.Private,
                "public" => ChatsCreateRequestChatPrivacy.Public,
                "team" => ChatsCreateRequestChatPrivacy.Team,
                "team-edit" => ChatsCreateRequestChatPrivacy.TeamEdit,
                "unlisted" => ChatsCreateRequestChatPrivacy.Unlisted,
                _ => null,
            };
        }
    }
}