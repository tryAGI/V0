
#nullable enable

namespace V0
{
    /// <summary>
    /// Specifies whether the message was sent by the user or the assistant.
    /// </summary>
    public enum ChatDetailMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatDetailMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatDetailMessageRole value)
        {
            return value switch
            {
                ChatDetailMessageRole.Assistant => "assistant",
                ChatDetailMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatDetailMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatDetailMessageRole.Assistant,
                "user" => ChatDetailMessageRole.User,
                _ => null,
            };
        }
    }
}