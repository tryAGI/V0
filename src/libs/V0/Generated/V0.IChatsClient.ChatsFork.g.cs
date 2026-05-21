#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Fork Chat<br/>
        /// Creates a new chat fork (duplicate) from a specific version within an existing chat. Useful for branching off alternate directions without modifying the original conversation.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsForkAsync(
            string chatId,

            global::V0.ChatsForkRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork Chat<br/>
        /// Creates a new chat fork (duplicate) from a specific version within an existing chat. Useful for branching off alternate directions without modifying the original conversation.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ChatDetail>> ChatsForkAsResponseAsync(
            string chatId,

            global::V0.ChatsForkRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork Chat<br/>
        /// Creates a new chat fork (duplicate) from a specific version within an existing chat. Useful for branching off alternate directions without modifying the original conversation.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId">
        /// The identifier of the specific chat version to fork from. If omitted, the latest version will be used.
        /// </param>
        /// <param name="privacy">
        /// Determines the privacy setting of the forked chat. This can control whether the chat is visible only to the user, to team members, or is public.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsForkAsync(
            string chatId,
            string? versionId = default,
            global::V0.ChatsForkRequestPrivacy? privacy = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}