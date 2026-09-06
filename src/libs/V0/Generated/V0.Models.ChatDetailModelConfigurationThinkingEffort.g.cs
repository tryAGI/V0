
#nullable enable

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatDetailModelConfigurationThinkingEffort
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
    public static class ChatDetailModelConfigurationThinkingEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatDetailModelConfigurationThinkingEffort value)
        {
            return value switch
            {
                ChatDetailModelConfigurationThinkingEffort.High => "high",
                ChatDetailModelConfigurationThinkingEffort.Low => "low",
                ChatDetailModelConfigurationThinkingEffort.Max => "max",
                ChatDetailModelConfigurationThinkingEffort.Medium => "medium",
                ChatDetailModelConfigurationThinkingEffort.Minimal => "minimal",
                ChatDetailModelConfigurationThinkingEffort.None => "none",
                ChatDetailModelConfigurationThinkingEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatDetailModelConfigurationThinkingEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatDetailModelConfigurationThinkingEffort.High,
                "low" => ChatDetailModelConfigurationThinkingEffort.Low,
                "max" => ChatDetailModelConfigurationThinkingEffort.Max,
                "medium" => ChatDetailModelConfigurationThinkingEffort.Medium,
                "minimal" => ChatDetailModelConfigurationThinkingEffort.Minimal,
                "none" => ChatDetailModelConfigurationThinkingEffort.None,
                "xhigh" => ChatDetailModelConfigurationThinkingEffort.Xhigh,
                _ => null,
            };
        }
    }
}