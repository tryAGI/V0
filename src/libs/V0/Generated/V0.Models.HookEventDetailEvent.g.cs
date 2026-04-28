
#nullable enable

namespace V0
{
    /// <summary>
    /// The type of event that triggered the webhook.
    /// </summary>
    public enum HookEventDetailEvent
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
    public static class HookEventDetailEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HookEventDetailEvent value)
        {
            return value switch
            {
                HookEventDetailEvent.ChatCreated => "chat.created",
                HookEventDetailEvent.ChatDeleted => "chat.deleted",
                HookEventDetailEvent.ChatUpdated => "chat.updated",
                HookEventDetailEvent.MessageCreated => "message.created",
                HookEventDetailEvent.MessageDeleted => "message.deleted",
                HookEventDetailEvent.MessageFinished => "message.finished",
                HookEventDetailEvent.MessageUpdated => "message.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HookEventDetailEvent? ToEnum(string value)
        {
            return value switch
            {
                "chat.created" => HookEventDetailEvent.ChatCreated,
                "chat.deleted" => HookEventDetailEvent.ChatDeleted,
                "chat.updated" => HookEventDetailEvent.ChatUpdated,
                "message.created" => HookEventDetailEvent.MessageCreated,
                "message.deleted" => HookEventDetailEvent.MessageDeleted,
                "message.finished" => HookEventDetailEvent.MessageFinished,
                "message.updated" => HookEventDetailEvent.MessageUpdated,
                _ => null,
            };
        }
    }
}