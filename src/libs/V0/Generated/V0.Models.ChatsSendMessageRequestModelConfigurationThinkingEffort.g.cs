
#nullable enable

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatsSendMessageRequestModelConfigurationThinkingEffort
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
    public static class ChatsSendMessageRequestModelConfigurationThinkingEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsSendMessageRequestModelConfigurationThinkingEffort value)
        {
            return value switch
            {
                ChatsSendMessageRequestModelConfigurationThinkingEffort.High => "high",
                ChatsSendMessageRequestModelConfigurationThinkingEffort.Low => "low",
                ChatsSendMessageRequestModelConfigurationThinkingEffort.Max => "max",
                ChatsSendMessageRequestModelConfigurationThinkingEffort.Medium => "medium",
                ChatsSendMessageRequestModelConfigurationThinkingEffort.Minimal => "minimal",
                ChatsSendMessageRequestModelConfigurationThinkingEffort.None => "none",
                ChatsSendMessageRequestModelConfigurationThinkingEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsSendMessageRequestModelConfigurationThinkingEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatsSendMessageRequestModelConfigurationThinkingEffort.High,
                "low" => ChatsSendMessageRequestModelConfigurationThinkingEffort.Low,
                "max" => ChatsSendMessageRequestModelConfigurationThinkingEffort.Max,
                "medium" => ChatsSendMessageRequestModelConfigurationThinkingEffort.Medium,
                "minimal" => ChatsSendMessageRequestModelConfigurationThinkingEffort.Minimal,
                "none" => ChatsSendMessageRequestModelConfigurationThinkingEffort.None,
                "xhigh" => ChatsSendMessageRequestModelConfigurationThinkingEffort.Xhigh,
                _ => null,
            };
        }
    }
}