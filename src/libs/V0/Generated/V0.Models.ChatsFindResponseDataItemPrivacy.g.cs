
#nullable enable

namespace V0
{
    /// <summary>
    /// Defines the visibility of the chat—private, team-only, or public.
    /// </summary>
    public enum ChatsFindResponseDataItemPrivacy
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
    public static class ChatsFindResponseDataItemPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsFindResponseDataItemPrivacy value)
        {
            return value switch
            {
                ChatsFindResponseDataItemPrivacy.Private => "private",
                ChatsFindResponseDataItemPrivacy.Public => "public",
                ChatsFindResponseDataItemPrivacy.Team => "team",
                ChatsFindResponseDataItemPrivacy.TeamEdit => "team-edit",
                ChatsFindResponseDataItemPrivacy.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsFindResponseDataItemPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ChatsFindResponseDataItemPrivacy.Private,
                "public" => ChatsFindResponseDataItemPrivacy.Public,
                "team" => ChatsFindResponseDataItemPrivacy.Team,
                "team-edit" => ChatsFindResponseDataItemPrivacy.TeamEdit,
                "unlisted" => ChatsFindResponseDataItemPrivacy.Unlisted,
                _ => null,
            };
        }
    }
}