
#nullable enable

namespace V0
{
    /// <summary>
    /// The type of authentication configured.
    /// </summary>
    public enum McpServersCreateResponseAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        CustomHeaders,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Oauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServersCreateResponseAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServersCreateResponseAuthType value)
        {
            return value switch
            {
                McpServersCreateResponseAuthType.Bearer => "bearer",
                McpServersCreateResponseAuthType.CustomHeaders => "custom-headers",
                McpServersCreateResponseAuthType.None => "none",
                McpServersCreateResponseAuthType.Oauth => "oauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServersCreateResponseAuthType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => McpServersCreateResponseAuthType.Bearer,
                "custom-headers" => McpServersCreateResponseAuthType.CustomHeaders,
                "none" => McpServersCreateResponseAuthType.None,
                "oauth" => McpServersCreateResponseAuthType.Oauth,
                _ => null,
            };
        }
    }
}