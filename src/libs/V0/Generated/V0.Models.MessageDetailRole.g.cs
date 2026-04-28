
#nullable enable

namespace V0
{
    /// <summary>
    /// Specifies whether the message was sent by the user or the assistant.
    /// </summary>
    public enum MessageDetailRole
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
    public static class MessageDetailRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDetailRole value)
        {
            return value switch
            {
                MessageDetailRole.Assistant => "assistant",
                MessageDetailRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDetailRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageDetailRole.Assistant,
                "user" => MessageDetailRole.User,
                _ => null,
            };
        }
    }
}