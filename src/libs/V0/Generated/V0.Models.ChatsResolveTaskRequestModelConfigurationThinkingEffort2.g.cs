
#nullable enable

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatsResolveTaskRequestModelConfigurationThinkingEffort2
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
    public static class ChatsResolveTaskRequestModelConfigurationThinkingEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestModelConfigurationThinkingEffort2 value)
        {
            return value switch
            {
                ChatsResolveTaskRequestModelConfigurationThinkingEffort2.High => "high",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort2.Low => "low",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort2.Max => "max",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort2.Medium => "medium",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort2.Minimal => "minimal",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort2.None => "none",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestModelConfigurationThinkingEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatsResolveTaskRequestModelConfigurationThinkingEffort2.High,
                "low" => ChatsResolveTaskRequestModelConfigurationThinkingEffort2.Low,
                "max" => ChatsResolveTaskRequestModelConfigurationThinkingEffort2.Max,
                "medium" => ChatsResolveTaskRequestModelConfigurationThinkingEffort2.Medium,
                "minimal" => ChatsResolveTaskRequestModelConfigurationThinkingEffort2.Minimal,
                "none" => ChatsResolveTaskRequestModelConfigurationThinkingEffort2.None,
                "xhigh" => ChatsResolveTaskRequestModelConfigurationThinkingEffort2.Xhigh,
                _ => null,
            };
        }
    }
}