#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Find Chat Messages<br/>
        /// Retrieves a list of all messages for a specific chat, ordered by creation date (newest first). Supports cursor-based pagination and includes message content, role, and type information.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="limit">
        /// Specifies the maximum number of message records to return in a single response. Useful for paginating results when there are many messages.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Base64 encoded cursor containing pagination data
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatsFindMessagesResponse> ChatsFindMessagesAsync(
            string chatId,
            double? limit = default,
            string? cursor = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}