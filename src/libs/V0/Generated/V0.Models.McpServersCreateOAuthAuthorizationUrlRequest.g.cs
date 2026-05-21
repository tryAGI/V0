
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersCreateOAuthAuthorizationUrlRequest
    {
        /// <summary>
        /// An absolute URL in your application where v0 redirects after OAuth completes. HTTPS is required in production.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReturnUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersCreateOAuthAuthorizationUrlRequest" /> class.
        /// </summary>
        /// <param name="returnUrl">
        /// An absolute URL in your application where v0 redirects after OAuth completes. HTTPS is required in production.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersCreateOAuthAuthorizationUrlRequest(
            string returnUrl)
        {
            this.ReturnUrl = returnUrl ?? throw new global::System.ArgumentNullException(nameof(returnUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersCreateOAuthAuthorizationUrlRequest" /> class.
        /// </summary>
        public McpServersCreateOAuthAuthorizationUrlRequest()
        {
        }

    }
}