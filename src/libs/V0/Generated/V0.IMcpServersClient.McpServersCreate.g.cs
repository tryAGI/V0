#nullable enable

namespace V0
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Create MCP Server<br/>
        /// Creates a new MCP server configuration for the authenticated user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.McpServersCreateResponse> McpServersCreateAsync(

            global::V0.McpServersCreateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create MCP Server<br/>
        /// Creates a new MCP server configuration for the authenticated user.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.McpServersCreateResponse> McpServersCreateAsync(
            string name,
            string url,
            string? description = default,
            bool? enabled = default,
            global::V0.AnyOf<global::V0.McpServersCreateRequestAuthVariant1, global::V0.McpServersCreateRequestAuthVariant2, global::V0.McpServersCreateRequestAuthVariant3>? auth = default,
            global::V0.McpServersCreateRequestScope? scope = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}