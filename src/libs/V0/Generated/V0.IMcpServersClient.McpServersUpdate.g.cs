#nullable enable

namespace V0
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Update MCP Server<br/>
        /// Updates the configuration of an existing MCP server, including its name, URL, description, enabled status, and authentication settings.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.McpServersUpdateResponse> McpServersUpdateAsync(
            string mcpServerId,

            global::V0.McpServersUpdateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update MCP Server<br/>
        /// Updates the configuration of an existing MCP server, including its name, URL, description, enabled status, and authentication settings.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.McpServersUpdateResponse>> McpServersUpdateAsResponseAsync(
            string mcpServerId,

            global::V0.McpServersUpdateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update MCP Server<br/>
        /// Updates the configuration of an existing MCP server, including its name, URL, description, enabled status, and authentication settings.
        /// </summary>
        /// <param name="mcpServerId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.McpServersUpdateResponse> McpServersUpdateAsync(
            string mcpServerId,
            string? name = default,
            string? url = default,
            string? description = default,
            bool? enabled = default,
            global::V0.AnyOf<global::V0.McpServersUpdateRequestAuthVariant1, global::V0.McpServersUpdateRequestAuthVariant2, global::V0.McpServersUpdateRequestAuthVariant3, global::V0.McpServersUpdateRequestAuthVariant4>? auth = default,
            global::V0.McpServersUpdateRequestScope? scope = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}