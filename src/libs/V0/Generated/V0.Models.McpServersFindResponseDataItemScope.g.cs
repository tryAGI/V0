
#nullable enable

namespace V0
{
    /// <summary>
    /// The scope of the MCP server (user or team).
    /// </summary>
    public enum McpServersFindResponseDataItemScope
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServersFindResponseDataItemScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServersFindResponseDataItemScope value)
        {
            return value switch
            {
                McpServersFindResponseDataItemScope.Team => "team",
                McpServersFindResponseDataItemScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServersFindResponseDataItemScope? ToEnum(string value)
        {
            return value switch
            {
                "team" => McpServersFindResponseDataItemScope.Team,
                "user" => McpServersFindResponseDataItemScope.User,
                _ => null,
            };
        }
    }
}