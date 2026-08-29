
#nullable enable

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatsCreateRequestModelConfigurationThinkingEffort2
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
    public static class ChatsCreateRequestModelConfigurationThinkingEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsCreateRequestModelConfigurationThinkingEffort2 value)
        {
            return value switch
            {
                ChatsCreateRequestModelConfigurationThinkingEffort2.High => "high",
                ChatsCreateRequestModelConfigurationThinkingEffort2.Low => "low",
                ChatsCreateRequestModelConfigurationThinkingEffort2.Max => "max",
                ChatsCreateRequestModelConfigurationThinkingEffort2.Medium => "medium",
                ChatsCreateRequestModelConfigurationThinkingEffort2.Minimal => "minimal",
                ChatsCreateRequestModelConfigurationThinkingEffort2.None => "none",
                ChatsCreateRequestModelConfigurationThinkingEffort2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsCreateRequestModelConfigurationThinkingEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatsCreateRequestModelConfigurationThinkingEffort2.High,
                "low" => ChatsCreateRequestModelConfigurationThinkingEffort2.Low,
                "max" => ChatsCreateRequestModelConfigurationThinkingEffort2.Max,
                "medium" => ChatsCreateRequestModelConfigurationThinkingEffort2.Medium,
                "minimal" => ChatsCreateRequestModelConfigurationThinkingEffort2.Minimal,
                "none" => ChatsCreateRequestModelConfigurationThinkingEffort2.None,
                "xhigh" => ChatsCreateRequestModelConfigurationThinkingEffort2.Xhigh,
                _ => null,
            };
        }
    }
}