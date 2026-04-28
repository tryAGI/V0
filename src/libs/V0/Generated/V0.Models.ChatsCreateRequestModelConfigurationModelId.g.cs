
#nullable enable

namespace V0
{
    /// <summary>
    /// Deprecated Model ID field preserved for backward compatibility.<br/>
    /// Default Value: v0-pro
    /// </summary>
    public enum ChatsCreateRequestModelConfigurationModelId
    {
        /// <summary>
        /// 
        /// </summary>
        V0Auto,
        /// <summary>
        /// 
        /// </summary>
        V0Max,
        /// <summary>
        /// 
        /// </summary>
        V0MaxFast,
        /// <summary>
        /// 
        /// </summary>
        V0Mini,
        /// <summary>
        /// 
        /// </summary>
        V0Opus47,
        /// <summary>
        /// 
        /// </summary>
        V0Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsCreateRequestModelConfigurationModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsCreateRequestModelConfigurationModelId value)
        {
            return value switch
            {
                ChatsCreateRequestModelConfigurationModelId.V0Auto => "v0-auto",
                ChatsCreateRequestModelConfigurationModelId.V0Max => "v0-max",
                ChatsCreateRequestModelConfigurationModelId.V0MaxFast => "v0-max-fast",
                ChatsCreateRequestModelConfigurationModelId.V0Mini => "v0-mini",
                ChatsCreateRequestModelConfigurationModelId.V0Opus47 => "v0-opus-4.7",
                ChatsCreateRequestModelConfigurationModelId.V0Pro => "v0-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsCreateRequestModelConfigurationModelId? ToEnum(string value)
        {
            return value switch
            {
                "v0-auto" => ChatsCreateRequestModelConfigurationModelId.V0Auto,
                "v0-max" => ChatsCreateRequestModelConfigurationModelId.V0Max,
                "v0-max-fast" => ChatsCreateRequestModelConfigurationModelId.V0MaxFast,
                "v0-mini" => ChatsCreateRequestModelConfigurationModelId.V0Mini,
                "v0-opus-4.7" => ChatsCreateRequestModelConfigurationModelId.V0Opus47,
                "v0-pro" => ChatsCreateRequestModelConfigurationModelId.V0Pro,
                _ => null,
            };
        }
    }
}