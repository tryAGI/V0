
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersCreateRequest
    {
        /// <summary>
        /// The display name of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The URL of the MCP server. Must be HTTPS in production.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// An optional description of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the MCP server is enabled. Defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Authentication configuration. Defaults to no authentication.<br/>
        /// Default Value: {"type":"none"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.McpServersCreateRequestAuthVariant1, global::V0.McpServersCreateRequestAuthVariant2, global::V0.McpServersCreateRequestAuthVariant3, global::V0.McpServersCreateRequestAuthVariant4>))]
        public global::V0.AnyOf<global::V0.McpServersCreateRequestAuthVariant1, global::V0.McpServersCreateRequestAuthVariant2, global::V0.McpServersCreateRequestAuthVariant3, global::V0.McpServersCreateRequestAuthVariant4>? Auth { get; set; }

        /// <summary>
        /// The scope of the MCP server. Defaults to user.<br/>
        /// Default Value: user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.McpServersCreateRequestScopeJsonConverter))]
        public global::V0.McpServersCreateRequestScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The display name of the MCP server.
        /// </param>
        /// <param name="url">
        /// The URL of the MCP server. Must be HTTPS in production.
        /// </param>
        /// <param name="description">
        /// An optional description of the MCP server.
        /// </param>
        /// <param name="enabled">
        /// Whether the MCP server is enabled. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="auth">
        /// Authentication configuration. Defaults to no authentication.<br/>
        /// Default Value: {"type":"none"}
        /// </param>
        /// <param name="scope">
        /// The scope of the MCP server. Defaults to user.<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersCreateRequest(
            string name,
            string url,
            string? description,
            bool? enabled,
            global::V0.AnyOf<global::V0.McpServersCreateRequestAuthVariant1, global::V0.McpServersCreateRequestAuthVariant2, global::V0.McpServersCreateRequestAuthVariant3, global::V0.McpServersCreateRequestAuthVariant4>? auth,
            global::V0.McpServersCreateRequestScope? scope)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Description = description;
            this.Enabled = enabled;
            this.Auth = auth;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersCreateRequest" /> class.
        /// </summary>
        public McpServersCreateRequest()
        {
        }
    }
}