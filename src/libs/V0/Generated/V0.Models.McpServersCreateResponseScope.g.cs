
#nullable enable

namespace V0
{
    /// <summary>
    /// The scope of the MCP server (user or team).
    /// </summary>
    public enum McpServersCreateResponseScope
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
    public static class McpServersCreateResponseScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServersCreateResponseScope value)
        {
            return value switch
            {
                McpServersCreateResponseScope.Team => "team",
                McpServersCreateResponseScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServersCreateResponseScope? ToEnum(string value)
        {
            return value switch
            {
                "team" => McpServersCreateResponseScope.Team,
                "user" => McpServersCreateResponseScope.User,
                _ => null,
            };
        }
    }
}