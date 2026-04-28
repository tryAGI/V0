
#nullable enable

namespace V0
{
    /// <summary>
    /// The reason why the message generation finished.
    /// </summary>
    public enum MessageSummaryFinishReason
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
    public static class MessageSummaryFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSummaryFinishReason value)
        {
            return value switch
            {
                MessageSummaryFinishReason.ContentFilter => "content-filter",
                MessageSummaryFinishReason.Error => "error",
                MessageSummaryFinishReason.Length => "length",
                MessageSummaryFinishReason.Other => "other",
                MessageSummaryFinishReason.Stop => "stop",
                MessageSummaryFinishReason.ToolCalls => "tool-calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSummaryFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content-filter" => MessageSummaryFinishReason.ContentFilter,
                "error" => MessageSummaryFinishReason.Error,
                "length" => MessageSummaryFinishReason.Length,
                "other" => MessageSummaryFinishReason.Other,
                "stop" => MessageSummaryFinishReason.Stop,
                "tool-calls" => MessageSummaryFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}