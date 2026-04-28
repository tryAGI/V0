
#nullable enable

namespace V0
{
    /// <summary>
    /// The scope of the MCP server.
    /// </summary>
    public enum McpServersUpdateRequestScope
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
    public static class McpServersUpdateRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServersUpdateRequestScope value)
        {
            return value switch
            {
                McpServersUpdateRequestScope.Team => "team",
                McpServersUpdateRequestScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServersUpdateRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "team" => McpServersUpdateRequestScope.Team,
                "user" => McpServersUpdateRequestScope.User,
                _ => null,
            };
        }
    }
}