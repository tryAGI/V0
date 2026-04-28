
#nullable enable

namespace V0
{
    /// <summary>
    /// The reason why the message generation finished.
    /// </summary>
    public enum MessageDetailFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDetailFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDetailFinishReason value)
        {
            return value switch
            {
                MessageDetailFinishReason.ContentFilter => "content-filter",
                MessageDetailFinishReason.Error => "error",
                MessageDetailFinishReason.Length => "length",
                MessageDetailFinishReason.Other => "other",
                MessageDetailFinishReason.Stop => "stop",
                MessageDetailFinishReason.ToolCalls => "tool-calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDetailFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content-filter" => MessageDetailFinishReason.ContentFilter,
                "error" => MessageDetailFinishReason.Error,
                "length" => MessageDetailFinishReason.Length,
                "other" => MessageDetailFinishReason.Other,
                "stop" => MessageDetailFinishReason.Stop,
                "tool-calls" => MessageDetailFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}