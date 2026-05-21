#nullable enable

namespace V0
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Create MCP Server OAuth Authorization URL<br/>
        /// Creates an OAuth authorization URL for an OAuth MCP server. Redirect the user to the returned URL, and the Platform API OAuth callback will store the resulting tokens before redirecting to your returnUrl.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.McpServersCreateOAuthAuthorizationUrlResponse> McpServersCreateOAuthAuthorizationUrlAsync(
            string mcpServerId,

            global::V0.McpServersCreateOAuthAuthorizationUrlRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create MCP Server OAuth Authorization URL<br/>
        /// Creates an OAuth authorization URL for an OAuth MCP server. Redirect the user to the returned URL, and the Platform API OAuth callback will store the resulting tokens before redirecting to your returnUrl.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.McpServersCreateOAuthAuthorizationUrlResponse>> McpServersCreateOAuthAuthorizationUrlAsResponseAsync(
            string mcpServerId,

            global::V0.McpServersCreateOAuthAuthorizationUrlRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create MCP Server OAuth Authorization URL<br/>
        /// Creates an OAuth authorization URL for an OAuth MCP server. Redirect the user to the returned URL, and the Platform API OAuth callback will store the resulting tokens before redirecting to your returnUrl.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="returnUrl">
        /// An absolute URL in your application where v0 redirects after OAuth completes. HTTPS is required in production.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.McpServersCreateOAuthAuthorizationUrlResponse> McpServersCreateOAuthAuthorizationUrlAsync(
            string mcpServerId,
            string returnUrl,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}