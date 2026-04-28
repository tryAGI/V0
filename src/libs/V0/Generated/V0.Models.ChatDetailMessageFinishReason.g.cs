
#nullable enable

namespace V0
{
    /// <summary>
    /// The reason why the message generation finished.
    /// </summary>
    public enum ChatDetailMessageFinishReason
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
    public static class ChatDetailMessageFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatDetailMessageFinishReason value)
        {
            return value switch
            {
                ChatDetailMessageFinishReason.ContentFilter => "content-filter",
                ChatDetailMessageFinishReason.Error => "error",
                ChatDetailMessageFinishReason.Length => "length",
                ChatDetailMessageFinishReason.Other => "other",
                ChatDetailMessageFinishReason.Stop => "stop",
                ChatDetailMessageFinishReason.ToolCalls => "tool-calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatDetailMessageFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content-filter" => ChatDetailMessageFinishReason.ContentFilter,
                "error" => ChatDetailMessageFinishReason.Error,
                "length" => ChatDetailMessageFinishReason.Length,
                "other" => ChatDetailMessageFinishReason.Other,
                "stop" => ChatDetailMessageFinishReason.Stop,
                "tool-calls" => ChatDetailMessageFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}