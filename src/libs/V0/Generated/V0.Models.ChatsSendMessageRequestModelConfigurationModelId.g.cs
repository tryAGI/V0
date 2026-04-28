
#nullable enable

namespace V0
{
    /// <summary>
    /// Deprecated Model ID field preserved for backward compatibility.<br/>
    /// Default Value: v0-pro
    /// </summary>
    public enum ChatsSendMessageRequestModelConfigurationModelId
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
    public static class ChatsSendMessageRequestModelConfigurationModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsSendMessageRequestModelConfigurationModelId value)
        {
            return value switch
            {
                ChatsSendMessageRequestModelConfigurationModelId.V0Auto => "v0-auto",
                ChatsSendMessageRequestModelConfigurationModelId.V0Max => "v0-max",
                ChatsSendMessageRequestModelConfigurationModelId.V0MaxFast => "v0-max-fast",
                ChatsSendMessageRequestModelConfigurationModelId.V0Mini => "v0-mini",
                ChatsSendMessageRequestModelConfigurationModelId.V0Opus47 => "v0-opus-4.7",
                ChatsSendMessageRequestModelConfigurationModelId.V0Pro => "v0-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsSendMessageRequestModelConfigurationModelId? ToEnum(string value)
        {
            return value switch
            {
                "v0-auto" => ChatsSendMessageRequestModelConfigurationModelId.V0Auto,
                "v0-max" => ChatsSendMessageRequestModelConfigurationModelId.V0Max,
                "v0-max-fast" => ChatsSendMessageRequestModelConfigurationModelId.V0MaxFast,
                "v0-mini" => ChatsSendMessageRequestModelConfigurationModelId.V0Mini,
                "v0-opus-4.7" => ChatsSendMessageRequestModelConfigurationModelId.V0Opus47,
                "v0-pro" => ChatsSendMessageRequestModelConfigurationModelId.V0Pro,
                _ => null,
            };
        }
    }
}