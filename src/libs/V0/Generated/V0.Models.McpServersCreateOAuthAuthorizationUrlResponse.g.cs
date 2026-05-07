
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersCreateOAuthAuthorizationUrlResponse
    {
        /// <summary>
        /// The object type.
        /// </summary>
        /// <default>"mcp_server_oauth_authorization"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "mcp_server_oauth_authorization";

        /// <summary>
        /// The MCP server being authorized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerId { get; set; }

        /// <summary>
        /// The provider authorization URL to redirect the user to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The OAuth state value. This expires after 5 minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// The ISO timestamp when the authorization URL expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersCreateOAuthAuthorizationUrlResponse" /> class.
        /// </summary>
        /// <param name="mcpServerId">
        /// The MCP server being authorized.
        /// </param>
        /// <param name="url">
        /// The provider authorization URL to redirect the user to.
        /// </param>
        /// <param name="state">
        /// The OAuth state value. This expires after 5 minutes.
        /// </param>
        /// <param name="expiresAt">
        /// The ISO timestamp when the authorization URL expires.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersCreateOAuthAuthorizationUrlResponse(
            string mcpServerId,
            string url,
            string state,
            global::System.DateTime expiresAt,
            string @object = "mcp_server_oauth_authorization")
        {
            this.Object = @object;
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersCreateOAuthAuthorizationUrlResponse" /> class.
        /// </summary>
        public McpServersCreateOAuthAuthorizationUrlResponse()
        {
        }
    }
}