
#nullable enable

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatsCreateRequestModelConfigurationThinkingEffort
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
    public static class ChatsCreateRequestModelConfigurationThinkingEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsCreateRequestModelConfigurationThinkingEffort value)
        {
            return value switch
            {
                ChatsCreateRequestModelConfigurationThinkingEffort.High => "high",
                ChatsCreateRequestModelConfigurationThinkingEffort.Low => "low",
                ChatsCreateRequestModelConfigurationThinkingEffort.Max => "max",
                ChatsCreateRequestModelConfigurationThinkingEffort.Medium => "medium",
                ChatsCreateRequestModelConfigurationThinkingEffort.Minimal => "minimal",
                ChatsCreateRequestModelConfigurationThinkingEffort.None => "none",
                ChatsCreateRequestModelConfigurationThinkingEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsCreateRequestModelConfigurationThinkingEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatsCreateRequestModelConfigurationThinkingEffort.High,
                "low" => ChatsCreateRequestModelConfigurationThinkingEffort.Low,
                "max" => ChatsCreateRequestModelConfigurationThinkingEffort.Max,
                "medium" => ChatsCreateRequestModelConfigurationThinkingEffort.Medium,
                "minimal" => ChatsCreateRequestModelConfigurationThinkingEffort.Minimal,
                "none" => ChatsCreateRequestModelConfigurationThinkingEffort.None,
                "xhigh" => ChatsCreateRequestModelConfigurationThinkingEffort.Xhigh,
                _ => null,
            };
        }
    }
}