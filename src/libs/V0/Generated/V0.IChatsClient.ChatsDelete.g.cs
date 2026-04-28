#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Delete Chat<br/>
        /// Deletes a specific chat based on the provided chatId. This operation is irreversible and permanently removes the chat and its contents.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatsDeleteResponse> ChatsDeleteAsync(
            string chatId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}