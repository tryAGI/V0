
#nullable enable

namespace V0
{
    /// <summary>
    /// OAuth configuration for the MCP server.
    /// </summary>
    public sealed partial class McpServersUpdateRequestAuthVariant4Config
    {
        /// <summary>
        /// The OAuth authorization endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthorizationUrl { get; set; }

        /// <summary>
        /// The OAuth token endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenUrl { get; set; }

        /// <summary>
        /// The optional dynamic client registration endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registrationUrl")]
        public string? RegistrationUrl { get; set; }

        /// <summary>
        /// The OAuth client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// The optional OAuth client secret. This value is stored securely and is never returned by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// OAuth scopes to request during authorization.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Whether to use PKCE for the authorization code flow.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usePKCE")]
        public bool? UsePKCE { get; set; }

        /// <summary>
        /// The optional issuer identifier for mix-up protection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        /// The optional RFC 8707 resource indicator. For MCP servers, this is usually the MCP server URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// Whether the authorization server supports Client ID Metadata Documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientIdMetadataDocumentSupported")]
        public bool? ClientIdMetadataDocumentSupported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersUpdateRequestAuthVariant4Config" /> class.
        /// </summary>
        /// <param name="authorizationUrl">
        /// The OAuth authorization endpoint URL.
        /// </param>
        /// <param name="tokenUrl">
        /// The OAuth token endpoint URL.
        /// </param>
        /// <param name="clientId">
        /// The OAuth client ID.
        /// </param>
        /// <param name="registrationUrl">
        /// The optional dynamic client registration endpoint URL.
        /// </param>
        /// <param name="clientSecret">
        /// The optional OAuth client secret. This value is stored securely and is never returned by the API.
        /// </param>
        /// <param name="scopes">
        /// OAuth scopes to request during authorization.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="usePKCE">
        /// Whether to use PKCE for the authorization code flow.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="issuer">
        /// The optional issuer identifier for mix-up protection.
        /// </param>
        /// <param name="resource">
        /// The optional RFC 8707 resource indicator. For MCP servers, this is usually the MCP server URL.
        /// </param>
        /// <param name="clientIdMetadataDocumentSupported">
        /// Whether the authorization server supports Client ID Metadata Documents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersUpdateRequestAuthVariant4Config(
            string authorizationUrl,
            string tokenUrl,
            string clientId,
            string? registrationUrl,
            string? clientSecret,
            global::System.Collections.Generic.IList<string>? scopes,
            bool? usePKCE,
            string? issuer,
            string? resource,
            bool? clientIdMetadataDocumentSupported)
        {
            this.AuthorizationUrl = authorizationUrl ?? throw new global::System.ArgumentNullException(nameof(authorizationUrl));
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.RegistrationUrl = registrationUrl;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.Scopes = scopes;
            this.UsePKCE = usePKCE;
            this.Issuer = issuer;
            this.Resource = resource;
            this.ClientIdMetadataDocumentSupported = clientIdMetadataDocumentSupported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersUpdateRequestAuthVariant4Config" /> class.
        /// </summary>
        public McpServersUpdateRequestAuthVariant4Config()
        {
        }
    }
}