#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Get Chat Message<br/>
        /// Retrieves detailed information about a specific message within a chat, including content, files, model configuration, and demo URLs.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.MessageDetail> ChatsGetMessageAsync(
            string chatId,
            string messageId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}