
#nullable enable

namespace V0
{
    /// <summary>
    /// Specifies whether the message was sent by the user or the assistant.
    /// </summary>
    public enum MessageSummaryRole
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
    public static class MessageSummaryRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSummaryRole value)
        {
            return value switch
            {
                MessageSummaryRole.Assistant => "assistant",
                MessageSummaryRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSummaryRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageSummaryRole.Assistant,
                "user" => MessageSummaryRole.User,
                _ => null,
            };
        }
    }
}