
#nullable enable

namespace V0
{
    /// <summary>
    /// Whether the skill lives in user or team memory.
    /// </summary>
    public enum ChatsCreateRequestSkillVariant2Scope
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
    public static class ChatsCreateRequestSkillVariant2ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsCreateRequestSkillVariant2Scope value)
        {
            return value switch
            {
                ChatsCreateRequestSkillVariant2Scope.Team => "team",
                ChatsCreateRequestSkillVariant2Scope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsCreateRequestSkillVariant2Scope? ToEnum(string value)
        {
            return value switch
            {
                "team" => ChatsCreateRequestSkillVariant2Scope.Team,
                "user" => ChatsCreateRequestSkillVariant2Scope.User,
                _ => null,
            };
        }
    }
}