
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum HooksUpdateRequestEvent
    {
        /// <summary>
        /// 
        /// </summary>
        ChatCreated,
        /// <summary>
        /// 
        /// </summary>
        ChatDeleted,
        /// <summary>
        /// 
        /// </summary>
        ChatUpdated,
        /// <summary>
        /// 
        /// </summary>
        MessageCreated,
        /// <summary>
        /// 
        /// </summary>
        MessageDeleted,
        /// <summary>
        /// 
        /// </summary>
        MessageFinished,
        /// <summary>
        /// 
        /// </summary>
        MessageUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HooksUpdateRequestEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HooksUpdateRequestEvent value)
        {
            return value switch
            {
                HooksUpdateRequestEvent.ChatCreated => "chat.created",
                HooksUpdateRequestEvent.ChatDeleted => "chat.deleted",
                HooksUpdateRequestEvent.ChatUpdated => "chat.updated",
                HooksUpdateRequestEvent.MessageCreated => "message.created",
                HooksUpdateRequestEvent.MessageDeleted => "message.deleted",
                HooksUpdateRequestEvent.MessageFinished => "message.finished",
                HooksUpdateRequestEvent.MessageUpdated => "message.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HooksUpdateRequestEvent? ToEnum(string value)
        {
            return value switch
            {
                "chat.created" => HooksUpdateRequestEvent.ChatCreated,
                "chat.deleted" => HooksUpdateRequestEvent.ChatDeleted,
                "chat.updated" => HooksUpdateRequestEvent.ChatUpdated,
                "message.created" => HooksUpdateRequestEvent.MessageCreated,
                "message.deleted" => HooksUpdateRequestEvent.MessageDeleted,
                "message.finished" => HooksUpdateRequestEvent.MessageFinished,
                "message.updated" => HooksUpdateRequestEvent.MessageUpdated,
                _ => null,
            };
        }
    }
}