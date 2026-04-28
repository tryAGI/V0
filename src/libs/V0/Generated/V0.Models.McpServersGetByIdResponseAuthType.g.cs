
#nullable enable

namespace V0
{
    /// <summary>
    /// The type of authentication configured.
    /// </summary>
    public enum McpServersGetByIdResponseAuthType
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
    public static class McpServersGetByIdResponseAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServersGetByIdResponseAuthType value)
        {
            return value switch
            {
                McpServersGetByIdResponseAuthType.Bearer => "bearer",
                McpServersGetByIdResponseAuthType.CustomHeaders => "custom-headers",
                McpServersGetByIdResponseAuthType.None => "none",
                McpServersGetByIdResponseAuthType.Oauth => "oauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServersGetByIdResponseAuthType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => McpServersGetByIdResponseAuthType.Bearer,
                "custom-headers" => McpServersGetByIdResponseAuthType.CustomHeaders,
                "none" => McpServersGetByIdResponseAuthType.None,
                "oauth" => McpServersGetByIdResponseAuthType.Oauth,
                _ => null,
            };
        }
    }
}