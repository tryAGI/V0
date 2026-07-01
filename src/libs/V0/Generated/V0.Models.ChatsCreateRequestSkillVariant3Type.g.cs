
#nullable enable

namespace V0
{
    /// <summary>
    /// Discriminator: a skill defined in the project repo.
    /// </summary>
    public enum ChatsCreateRequestSkillVariant3Type
    {
        /// <summary>
        /// a skill defined in the project repo.
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsCreateRequestSkillVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsCreateRequestSkillVariant3Type value)
        {
            return value switch
            {
                ChatsCreateRequestSkillVariant3Type.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsCreateRequestSkillVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "project" => ChatsCreateRequestSkillVariant3Type.Project,
                _ => null,
            };
        }
    }
}