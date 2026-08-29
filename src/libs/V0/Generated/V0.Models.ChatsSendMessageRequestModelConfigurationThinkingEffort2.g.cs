
#nullable enable

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatsSendMessageRequestModelConfigurationThinkingEffort2
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Minimal,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsSendMessageRequestModelConfigurationThinkingEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsSendMessageRequestModelConfigurationThinkingEffort2 value)
        {
            return value switch
            {
                ChatsSendMessageRequestModelConfigurationThinkingEffort2.High => "high",
                ChatsSendMessageRequestModelConfigurationThinkingEffort2.Low => "low",
                ChatsSendMessageRequestModelConfigurationThinkingEffort2.Max => "max",
                ChatsSendMessageRequestModelConfigurationThinkingEffort2.Medium => "medium",
                ChatsSendMessageRequestModelConfigurationThinkingEffort2.Minimal => "minimal",
                ChatsSendMessageRequestModelConfigurationThinkingEffort2.None => "none",
                ChatsSendMessageRequestModelConfigurationThinkingEffort2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsSendMessageRequestModelConfigurationThinkingEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatsSendMessageRequestModelConfigurationThinkingEffort2.High,
                "low" => ChatsSendMessageRequestModelConfigurationThinkingEffort2.Low,
                "max" => ChatsSendMessageRequestModelConfigurationThinkingEffort2.Max,
                "medium" => ChatsSendMessageRequestModelConfigurationThinkingEffort2.Medium,
                "minimal" => ChatsSendMessageRequestModelConfigurationThinkingEffort2.Minimal,
                "none" => ChatsSendMessageRequestModelConfigurationThinkingEffort2.None,
                "xhigh" => ChatsSendMessageRequestModelConfigurationThinkingEffort2.Xhigh,
                _ => null,
            };
        }
    }
}