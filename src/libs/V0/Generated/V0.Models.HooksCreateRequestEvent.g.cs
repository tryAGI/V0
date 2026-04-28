
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum HooksCreateRequestEvent
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
    public static class HooksCreateRequestEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HooksCreateRequestEvent value)
        {
            return value switch
            {
                HooksCreateRequestEvent.ChatCreated => "chat.created",
                HooksCreateRequestEvent.ChatDeleted => "chat.deleted",
                HooksCreateRequestEvent.ChatUpdated => "chat.updated",
                HooksCreateRequestEvent.MessageCreated => "message.created",
                HooksCreateRequestEvent.MessageDeleted => "message.deleted",
                HooksCreateRequestEvent.MessageFinished => "message.finished",
                HooksCreateRequestEvent.MessageUpdated => "message.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HooksCreateRequestEvent? ToEnum(string value)
        {
            return value switch
            {
                "chat.created" => HooksCreateRequestEvent.ChatCreated,
                "chat.deleted" => HooksCreateRequestEvent.ChatDeleted,
                "chat.updated" => HooksCreateRequestEvent.ChatUpdated,
                "message.created" => HooksCreateRequestEvent.MessageCreated,
                "message.deleted" => HooksCreateRequestEvent.MessageDeleted,
                "message.finished" => HooksCreateRequestEvent.MessageFinished,
                "message.updated" => HooksCreateRequestEvent.MessageUpdated,
                _ => null,
            };
        }
    }
}