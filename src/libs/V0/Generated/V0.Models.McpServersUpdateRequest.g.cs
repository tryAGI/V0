
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersUpdateRequest
    {
        /// <summary>
        /// The display name of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The URL of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// An optional description of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the MCP server is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Authentication configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.McpServersUpdateRequestAuthVariant1, global::V0.McpServersUpdateRequestAuthVariant2, global::V0.McpServersUpdateRequestAuthVariant3, global::V0.McpServersUpdateRequestAuthVariant4>))]
        public global::V0.AnyOf<global::V0.McpServersUpdateRequestAuthVariant1, global::V0.McpServersUpdateRequestAuthVariant2, global::V0.McpServersUpdateRequestAuthVariant3, global::V0.McpServersUpdateRequestAuthVariant4>? Auth { get; set; }

        /// <summary>
        /// The scope of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.McpServersUpdateRequestScopeJsonConverter))]
        public global::V0.McpServersUpdateRequestScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The display name of the MCP server.
        /// </param>
        /// <param name="url">
        /// The URL of the MCP server.
        /// </param>
        /// <param name="description">
        /// An optional description of the MCP server.
        /// </param>
        /// <param name="enabled">
        /// Whether the MCP server is enabled.
        /// </param>
        /// <param name="auth">
        /// Authentication configuration.
        /// </param>
        /// <param name="scope">
        /// The scope of the MCP server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersUpdateRequest(
            string? name,
            string? url,
            string? description,
            bool? enabled,
            global::V0.AnyOf<global::V0.McpServersUpdateRequestAuthVariant1, global::V0.McpServersUpdateRequestAuthVariant2, global::V0.McpServersUpdateRequestAuthVariant3, global::V0.McpServersUpdateRequestAuthVariant4>? auth,
            global::V0.McpServersUpdateRequestScope? scope)
        {
            this.Name = name;
            this.Url = url;
            this.Description = description;
            this.Enabled = enabled;
            this.Auth = auth;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersUpdateRequest" /> class.
        /// </summary>
        public McpServersUpdateRequest()
        {
        }
    }
}