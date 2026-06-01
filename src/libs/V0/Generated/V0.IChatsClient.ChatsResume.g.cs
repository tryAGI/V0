#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Resume Message<br/>
        /// Reconnects to an active assistant message stream and returns it as Server-Sent Events. This does not restart or continue a stopped generation.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> ChatsResumeAsync(
            string chatId,
            string messageId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}