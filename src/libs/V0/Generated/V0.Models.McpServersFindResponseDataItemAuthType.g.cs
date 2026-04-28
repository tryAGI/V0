
#nullable enable

namespace V0
{
    /// <summary>
    /// The type of authentication configured.
    /// </summary>
    public enum McpServersFindResponseDataItemAuthType
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
    public static class McpServersFindResponseDataItemAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServersFindResponseDataItemAuthType value)
        {
            return value switch
            {
                McpServersFindResponseDataItemAuthType.Bearer => "bearer",
                McpServersFindResponseDataItemAuthType.CustomHeaders => "custom-headers",
                McpServersFindResponseDataItemAuthType.None => "none",
                McpServersFindResponseDataItemAuthType.Oauth => "oauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServersFindResponseDataItemAuthType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => McpServersFindResponseDataItemAuthType.Bearer,
                "custom-headers" => McpServersFindResponseDataItemAuthType.CustomHeaders,
                "none" => McpServersFindResponseDataItemAuthType.None,
                "oauth" => McpServersFindResponseDataItemAuthType.Oauth,
                _ => null,
            };
        }
    }
}