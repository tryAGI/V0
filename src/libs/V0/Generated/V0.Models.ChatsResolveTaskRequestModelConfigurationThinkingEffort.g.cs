
#nullable enable

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatsResolveTaskRequestModelConfigurationThinkingEffort
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
    public static class ChatsResolveTaskRequestModelConfigurationThinkingEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestModelConfigurationThinkingEffort value)
        {
            return value switch
            {
                ChatsResolveTaskRequestModelConfigurationThinkingEffort.High => "high",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort.Low => "low",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort.Max => "max",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort.Medium => "medium",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort.Minimal => "minimal",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort.None => "none",
                ChatsResolveTaskRequestModelConfigurationThinkingEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestModelConfigurationThinkingEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatsResolveTaskRequestModelConfigurationThinkingEffort.High,
                "low" => ChatsResolveTaskRequestModelConfigurationThinkingEffort.Low,
                "max" => ChatsResolveTaskRequestModelConfigurationThinkingEffort.Max,
                "medium" => ChatsResolveTaskRequestModelConfigurationThinkingEffort.Medium,
                "minimal" => ChatsResolveTaskRequestModelConfigurationThinkingEffort.Minimal,
                "none" => ChatsResolveTaskRequestModelConfigurationThinkingEffort.None,
                "xhigh" => ChatsResolveTaskRequestModelConfigurationThinkingEffort.Xhigh,
                _ => null,
            };
        }
    }
}