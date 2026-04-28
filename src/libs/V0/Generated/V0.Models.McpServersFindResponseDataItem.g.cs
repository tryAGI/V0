
#nullable enable

namespace V0
{
    /// <summary>
    /// Summary information about an MCP server.
    /// </summary>
    public sealed partial class McpServersFindResponseDataItem
    {
        /// <summary>
        /// The object type.
        /// </summary>
        /// <default>"mcp_server"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "mcp_server";

        /// <summary>
        /// The unique identifier for the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The display name of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The URL of the MCP server.
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
        /// Whether the MCP server is enabled for use in chats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Authentication type for the MCP server. Sensitive values like tokens and headers are not returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.McpServersFindResponseDataItemAuth Auth { get; set; }

        /// <summary>
        /// The scope of the MCP server (user or team).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.McpServersFindResponseDataItemScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.McpServersFindResponseDataItemScope Scope { get; set; }

        /// <summary>
        /// The ISO timestamp when the MCP server was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ISO timestamp when the MCP server was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersFindResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the MCP server.
        /// </param>
        /// <param name="name">
        /// The display name of the MCP server.
        /// </param>
        /// <param name="url">
        /// The URL of the MCP server.
        /// </param>
        /// <param name="enabled">
        /// Whether the MCP server is enabled for use in chats.
        /// </param>
        /// <param name="auth">
        /// Authentication type for the MCP server. Sensitive values like tokens and headers are not returned.
        /// </param>
        /// <param name="scope">
        /// The scope of the MCP server (user or team).
        /// </param>
        /// <param name="createdAt">
        /// The ISO timestamp when the MCP server was created.
        /// </param>
        /// <param name="description">
        /// An optional description of the MCP server.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO timestamp when the MCP server was last updated.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersFindResponseDataItem(
            string id,
            string name,
            string url,
            bool enabled,
            global::V0.McpServersFindResponseDataItemAuth auth,
            global::V0.McpServersFindResponseDataItemScope scope,
            global::System.DateTime createdAt,
            string? description,
            global::System.DateTime? updatedAt,
            string @object = "mcp_server")
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Description = description;
            this.Enabled = enabled;
            this.Auth = auth ?? throw new global::System.ArgumentNullException(nameof(auth));
            this.Scope = scope;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersFindResponseDataItem" /> class.
        /// </summary>
        public McpServersFindResponseDataItem()
        {
        }
    }
}