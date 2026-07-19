
#nullable enable

namespace V0
{
    /// <summary>
    /// Model to use for the generation. `v0-auto` is deprecated and falls back to `v0-pro`.<br/>
    /// Default Value: v0-pro
    /// </summary>
    public enum ChatDetailModelConfigurationModelId
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
        V0Opus47Fast,
        /// <summary>
        /// 
        /// </summary>
        V0Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatDetailModelConfigurationModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatDetailModelConfigurationModelId value)
        {
            return value switch
            {
                ChatDetailModelConfigurationModelId.V0Auto => "v0-auto",
                ChatDetailModelConfigurationModelId.V0Max => "v0-max",
                ChatDetailModelConfigurationModelId.V0MaxFast => "v0-max-fast",
                ChatDetailModelConfigurationModelId.V0Mini => "v0-mini",
                ChatDetailModelConfigurationModelId.V0Opus47 => "v0-opus-4.7",
                ChatDetailModelConfigurationModelId.V0Opus47Fast => "v0-opus-4.7-fast",
                ChatDetailModelConfigurationModelId.V0Pro => "v0-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatDetailModelConfigurationModelId? ToEnum(string value)
        {
            return value switch
            {
                "v0-auto" => ChatDetailModelConfigurationModelId.V0Auto,
                "v0-max" => ChatDetailModelConfigurationModelId.V0Max,
                "v0-max-fast" => ChatDetailModelConfigurationModelId.V0MaxFast,
                "v0-mini" => ChatDetailModelConfigurationModelId.V0Mini,
                "v0-opus-4.7" => ChatDetailModelConfigurationModelId.V0Opus47,
                "v0-opus-4.7-fast" => ChatDetailModelConfigurationModelId.V0Opus47Fast,
                "v0-pro" => ChatDetailModelConfigurationModelId.V0Pro,
                _ => null,
            };
        }
    }
}