
#nullable enable

namespace V0
{
    /// <summary>
    /// The reason why the message generation finished.
    /// </summary>
    public enum MessageSummaryListDataItemFinishReason
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
    public static class MessageSummaryListDataItemFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSummaryListDataItemFinishReason value)
        {
            return value switch
            {
                MessageSummaryListDataItemFinishReason.ContentFilter => "content-filter",
                MessageSummaryListDataItemFinishReason.Error => "error",
                MessageSummaryListDataItemFinishReason.Length => "length",
                MessageSummaryListDataItemFinishReason.Other => "other",
                MessageSummaryListDataItemFinishReason.Stop => "stop",
                MessageSummaryListDataItemFinishReason.ToolCalls => "tool-calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSummaryListDataItemFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content-filter" => MessageSummaryListDataItemFinishReason.ContentFilter,
                "error" => MessageSummaryListDataItemFinishReason.Error,
                "length" => MessageSummaryListDataItemFinishReason.Length,
                "other" => MessageSummaryListDataItemFinishReason.Other,
                "stop" => MessageSummaryListDataItemFinishReason.Stop,
                "tool-calls" => MessageSummaryListDataItemFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}