#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Update Chat<br/>
        /// Updates the metadata of an existing chat using its `chatId`. Supports changes to the chat name and privacy setting.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsUpdateAsync(
            string chatId,

            global::V0.ChatsUpdateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Chat<br/>
        /// Updates the metadata of an existing chat using its `chatId`. Supports changes to the chat name and privacy setting.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="name">
        /// A new name to assign to the chat. Helps with identification and organization.
        /// </param>
        /// <param name="privacy">
        /// Sets the privacy level of the chat.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value data to attach to the chat. Useful for storing additional data about the chat, such as external user IDs. Metadata added will be merged with existing attributes. Pass `null` as the value to delete a specific key, or pass `null` instead of an object to delete all existing metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsUpdateAsync(
            string chatId,
            string? name = default,
            global::V0.ChatsUpdateRequestPrivacy? privacy = default,
            object? metadata = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}