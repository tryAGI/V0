#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Favorite Chat<br/>
        /// Marks or unmarks a chat as a favorite using its `chatId`. This helps with organizing and quickly accessing important chats.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatsFavoriteResponse> ChatsFavoriteAsync(
            string chatId,

            global::V0.ChatsFavoriteRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Favorite Chat<br/>
        /// Marks or unmarks a chat as a favorite using its `chatId`. This helps with organizing and quickly accessing important chats.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ChatsFavoriteResponse>> ChatsFavoriteAsResponseAsync(
            string chatId,

            global::V0.ChatsFavoriteRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Favorite Chat<br/>
        /// Marks or unmarks a chat as a favorite using its `chatId`. This helps with organizing and quickly accessing important chats.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="isFavorite">
        /// Specifies whether the chat should be marked as a favorite.<br/>
        /// - `"true"`: mark as favorite<br/>
        /// - `"false"`: remove from favorites
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatsFavoriteResponse> ChatsFavoriteAsync(
            string chatId,
            bool isFavorite,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}