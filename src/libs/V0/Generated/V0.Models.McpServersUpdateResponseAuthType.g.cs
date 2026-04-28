
#nullable enable

namespace V0
{
    /// <summary>
    /// The type of authentication configured.
    /// </summary>
    public enum McpServersUpdateResponseAuthType
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
    public static class McpServersUpdateResponseAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServersUpdateResponseAuthType value)
        {
            return value switch
            {
                McpServersUpdateResponseAuthType.Bearer => "bearer",
                McpServersUpdateResponseAuthType.CustomHeaders => "custom-headers",
                McpServersUpdateResponseAuthType.None => "none",
                McpServersUpdateResponseAuthType.Oauth => "oauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServersUpdateResponseAuthType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => McpServersUpdateResponseAuthType.Bearer,
                "custom-headers" => McpServersUpdateResponseAuthType.CustomHeaders,
                "none" => McpServersUpdateResponseAuthType.None,
                "oauth" => McpServersUpdateResponseAuthType.Oauth,
                _ => null,
            };
        }
    }
}