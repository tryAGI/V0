
#nullable enable

namespace V0
{
    /// <summary>
    /// Model to use for the generation. `v0-auto` is deprecated and falls back to `v0-pro`.<br/>
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
                "v0-pro" => ChatsSendMessageRequestModelConfigurationModelId.V0Pro,
                _ => null,
            };
        }
    }
}