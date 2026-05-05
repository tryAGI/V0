#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Stop Message<br/>
        /// Stops an in-flight message generation in a chat. Useful for cancelling a streaming response that is still being generated.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatsStopResponse> ChatsStopAsync(
            string chatId,
            string messageId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop Message<br/>
        /// Stops an in-flight message generation in a chat. Useful for cancelling a streaming response that is still being generated.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ChatsStopResponse>> ChatsStopAsResponseAsync(
            string chatId,
            string messageId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}