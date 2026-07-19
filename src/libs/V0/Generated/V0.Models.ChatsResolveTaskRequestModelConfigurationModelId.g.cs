
#nullable enable

namespace V0
{
    /// <summary>
    /// Model to use for the generation. `v0-auto` is deprecated and falls back to `v0-pro`.<br/>
    /// Default Value: v0-pro
    /// </summary>
    public enum ChatsResolveTaskRequestModelConfigurationModelId
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
    public static class ChatsResolveTaskRequestModelConfigurationModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestModelConfigurationModelId value)
        {
            return value switch
            {
                ChatsResolveTaskRequestModelConfigurationModelId.V0Auto => "v0-auto",
                ChatsResolveTaskRequestModelConfigurationModelId.V0Max => "v0-max",
                ChatsResolveTaskRequestModelConfigurationModelId.V0MaxFast => "v0-max-fast",
                ChatsResolveTaskRequestModelConfigurationModelId.V0Mini => "v0-mini",
                ChatsResolveTaskRequestModelConfigurationModelId.V0Pro => "v0-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestModelConfigurationModelId? ToEnum(string value)
        {
            return value switch
            {
                "v0-auto" => ChatsResolveTaskRequestModelConfigurationModelId.V0Auto,
                "v0-max" => ChatsResolveTaskRequestModelConfigurationModelId.V0Max,
                "v0-max-fast" => ChatsResolveTaskRequestModelConfigurationModelId.V0MaxFast,
                "v0-mini" => ChatsResolveTaskRequestModelConfigurationModelId.V0Mini,
                "v0-pro" => ChatsResolveTaskRequestModelConfigurationModelId.V0Pro,
                _ => null,
            };
        }
    }
}