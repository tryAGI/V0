
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum HookDetailEvent
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
    public static class HookDetailEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HookDetailEvent value)
        {
            return value switch
            {
                HookDetailEvent.ChatCreated => "chat.created",
                HookDetailEvent.ChatDeleted => "chat.deleted",
                HookDetailEvent.ChatUpdated => "chat.updated",
                HookDetailEvent.MessageCreated => "message.created",
                HookDetailEvent.MessageDeleted => "message.deleted",
                HookDetailEvent.MessageFinished => "message.finished",
                HookDetailEvent.MessageUpdated => "message.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HookDetailEvent? ToEnum(string value)
        {
            return value switch
            {
                "chat.created" => HookDetailEvent.ChatCreated,
                "chat.deleted" => HookDetailEvent.ChatDeleted,
                "chat.updated" => HookDetailEvent.ChatUpdated,
                "message.created" => HookDetailEvent.MessageCreated,
                "message.deleted" => HookDetailEvent.MessageDeleted,
                "message.finished" => HookDetailEvent.MessageFinished,
                "message.updated" => HookDetailEvent.MessageUpdated,
                _ => null,
            };
        }
    }
}