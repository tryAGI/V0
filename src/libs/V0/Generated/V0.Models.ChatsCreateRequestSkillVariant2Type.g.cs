
#nullable enable

namespace V0
{
    /// <summary>
    /// Discriminator: a user- or team-scoped memory skill.
    /// </summary>
    public enum ChatsCreateRequestSkillVariant2Type
    {
        /// <summary>
        /// a user- or team-scoped memory skill.
        /// </summary>
        Memory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsCreateRequestSkillVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsCreateRequestSkillVariant2Type value)
        {
            return value switch
            {
                ChatsCreateRequestSkillVariant2Type.Memory => "memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsCreateRequestSkillVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "memory" => ChatsCreateRequestSkillVariant2Type.Memory,
                _ => null,
            };
        }
    }
}