#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Resume Message<br/>
        /// Resumes processing of a previously interrupted or incomplete message in a chat. Useful for continuing generation when a message was paused or stopped.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.MessageDetail> ChatsResumeAsync(
            string chatId,
            string messageId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}