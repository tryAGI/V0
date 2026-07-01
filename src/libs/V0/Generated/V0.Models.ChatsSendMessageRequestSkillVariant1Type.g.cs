
#nullable enable

namespace V0
{
    /// <summary>
    /// Discriminator: a skills.sh skill.
    /// </summary>
    public enum ChatsSendMessageRequestSkillVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Remote,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsSendMessageRequestSkillVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsSendMessageRequestSkillVariant1Type value)
        {
            return value switch
            {
                ChatsSendMessageRequestSkillVariant1Type.Remote => "remote",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsSendMessageRequestSkillVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "remote" => ChatsSendMessageRequestSkillVariant1Type.Remote,
                _ => null,
            };
        }
    }
}