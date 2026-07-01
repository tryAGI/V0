
#nullable enable

namespace V0
{
    /// <summary>
    /// Whether the skill lives in user or team memory.
    /// </summary>
    public enum ChatsSendMessageRequestSkillVariant2Scope
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsSendMessageRequestSkillVariant2ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsSendMessageRequestSkillVariant2Scope value)
        {
            return value switch
            {
                ChatsSendMessageRequestSkillVariant2Scope.Team => "team",
                ChatsSendMessageRequestSkillVariant2Scope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsSendMessageRequestSkillVariant2Scope? ToEnum(string value)
        {
            return value switch
            {
                "team" => ChatsSendMessageRequestSkillVariant2Scope.Team,
                "user" => ChatsSendMessageRequestSkillVariant2Scope.User,
                _ => null,
            };
        }
    }
}