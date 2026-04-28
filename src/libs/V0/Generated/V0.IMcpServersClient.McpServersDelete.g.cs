#nullable enable

namespace V0
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Delete MCP Server<br/>
        /// Deletes an MCP server based on its ID. This action is irreversible and will also remove any associated OAuth tokens.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.McpServersDeleteResponse> McpServersDeleteAsync(
            string mcpServerId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}