#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Find Chat Versions<br/>
        /// Retrieves a list of all versions (iterations) for a specific chat, ordered by creation date (newest first). Supports cursor-based pagination and includes version status and demo URLs.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="limit">
        /// Specifies the maximum number of version records to return in a single response. Useful for paginating results when there are many versions.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Base64 encoded cursor containing pagination data
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatsFindVersionsResponse> ChatsFindVersionsAsync(
            string chatId,
            double? limit = default,
            string? cursor = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find Chat Versions<br/>
        /// Retrieves a list of all versions (iterations) for a specific chat, ordered by creation date (newest first). Supports cursor-based pagination and includes version status and demo URLs.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="limit">
        /// Specifies the maximum number of version records to return in a single response. Useful for paginating results when there are many versions.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Base64 encoded cursor containing pagination data
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ChatsFindVersionsResponse>> ChatsFindVersionsAsResponseAsync(
            string chatId,
            double? limit = default,
            string? cursor = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}