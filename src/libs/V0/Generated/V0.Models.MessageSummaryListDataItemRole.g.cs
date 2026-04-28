
#nullable enable

namespace V0
{
    /// <summary>
    /// Specifies whether the message was sent by the user or the assistant.
    /// </summary>
    public enum MessageSummaryListDataItemRole
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
    public static class MessageSummaryListDataItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSummaryListDataItemRole value)
        {
            return value switch
            {
                MessageSummaryListDataItemRole.Assistant => "assistant",
                MessageSummaryListDataItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSummaryListDataItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageSummaryListDataItemRole.Assistant,
                "user" => MessageSummaryListDataItemRole.User,
                _ => null,
            };
        }
    }
}