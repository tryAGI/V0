#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Get Chat<br/>
        /// Retrieves the full details of a specific chat using its `chatId`. Includes messages, metadata, and associated configuration.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsGetByIdAsync(
            string chatId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Chat<br/>
        /// Retrieves the full details of a specific chat using its `chatId`. Includes messages, metadata, and associated configuration.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ChatDetail>> ChatsGetByIdAsResponseAsync(
            string chatId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}