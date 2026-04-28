
#nullable enable

namespace V0
{
    /// <summary>
    /// Determines the privacy setting of the forked chat. This can control whether the chat is visible only to the user, to team members, or is public.<br/>
    /// Default Value: private
    /// </summary>
    public enum ChatsForkRequestPrivacy
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
    public static class ChatsForkRequestPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsForkRequestPrivacy value)
        {
            return value switch
            {
                ChatsForkRequestPrivacy.Private => "private",
                ChatsForkRequestPrivacy.Public => "public",
                ChatsForkRequestPrivacy.Team => "team",
                ChatsForkRequestPrivacy.TeamEdit => "team-edit",
                ChatsForkRequestPrivacy.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsForkRequestPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "private" => ChatsForkRequestPrivacy.Private,
                "public" => ChatsForkRequestPrivacy.Public,
                "team" => ChatsForkRequestPrivacy.Team,
                "team-edit" => ChatsForkRequestPrivacy.TeamEdit,
                "unlisted" => ChatsForkRequestPrivacy.Unlisted,
                _ => null,
            };
        }
    }
}