
#nullable enable

namespace V0
{
    /// <summary>
    /// The scope of the MCP server. Defaults to user.<br/>
    /// Default Value: user
    /// </summary>
    public enum McpServersCreateRequestScope
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
    public static class McpServersCreateRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServersCreateRequestScope value)
        {
            return value switch
            {
                McpServersCreateRequestScope.Team => "team",
                McpServersCreateRequestScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServersCreateRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "team" => McpServersCreateRequestScope.Team,
                "user" => McpServersCreateRequestScope.User,
                _ => null,
            };
        }
    }
}