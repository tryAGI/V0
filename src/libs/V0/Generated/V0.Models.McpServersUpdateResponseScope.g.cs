
#nullable enable

namespace V0
{
    /// <summary>
    /// The scope of the MCP server (user or team).
    /// </summary>
    public enum McpServersUpdateResponseScope
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
    public static class McpServersUpdateResponseScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServersUpdateResponseScope value)
        {
            return value switch
            {
                McpServersUpdateResponseScope.Team => "team",
                McpServersUpdateResponseScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServersUpdateResponseScope? ToEnum(string value)
        {
            return value switch
            {
                "team" => McpServersUpdateResponseScope.Team,
                "user" => McpServersUpdateResponseScope.User,
                _ => null,
            };
        }
    }
}