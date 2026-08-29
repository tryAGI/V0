
#nullable enable

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatDetailModelConfigurationThinkingEffort2
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
    public static class ChatDetailModelConfigurationThinkingEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatDetailModelConfigurationThinkingEffort2 value)
        {
            return value switch
            {
                ChatDetailModelConfigurationThinkingEffort2.High => "high",
                ChatDetailModelConfigurationThinkingEffort2.Low => "low",
                ChatDetailModelConfigurationThinkingEffort2.Max => "max",
                ChatDetailModelConfigurationThinkingEffort2.Medium => "medium",
                ChatDetailModelConfigurationThinkingEffort2.Minimal => "minimal",
                ChatDetailModelConfigurationThinkingEffort2.None => "none",
                ChatDetailModelConfigurationThinkingEffort2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatDetailModelConfigurationThinkingEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatDetailModelConfigurationThinkingEffort2.High,
                "low" => ChatDetailModelConfigurationThinkingEffort2.Low,
                "max" => ChatDetailModelConfigurationThinkingEffort2.Max,
                "medium" => ChatDetailModelConfigurationThinkingEffort2.Medium,
                "minimal" => ChatDetailModelConfigurationThinkingEffort2.Minimal,
                "none" => ChatDetailModelConfigurationThinkingEffort2.None,
                "xhigh" => ChatDetailModelConfigurationThinkingEffort2.Xhigh,
                _ => null,
            };
        }
    }
}