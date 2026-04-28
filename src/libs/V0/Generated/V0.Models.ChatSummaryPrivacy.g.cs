
#nullable enable

namespace V0
{
    /// <summary>
    /// Defines the visibility of the chat—private, team-only, or public.
    /// </summary>
    public enum ChatSummaryPrivacy
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
    public static class ChatSummaryPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSummaryPrivacy value)
        {
            return value switch
            {
                ChatSummaryPrivacy.Private => "private",
                ChatSummaryPrivacy.Public => "public",
                ChatSummaryPrivacy.Team => "team",
                ChatSummaryPrivacy.TeamEdit => "team-edit",
                ChatSummaryPrivacy.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSummaryPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ChatSummaryPrivacy.Private,
                "public" => ChatSummaryPrivacy.Public,
                "team" => ChatSummaryPrivacy.Team,
                "team-edit" => ChatSummaryPrivacy.TeamEdit,
                "unlisted" => ChatSummaryPrivacy.Unlisted,
                _ => null,
            };
        }
    }
}