#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Update Chat Version Files<br/>
        /// Updates the source files of a specific chat version (block) manually. This allows editing generated files directly through the API.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.VersionDetail> ChatsUpdateVersionAsync(
            string chatId,
            string versionId,

            global::V0.ChatsUpdateVersionRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Chat Version Files<br/>
        /// Updates the source files of a specific chat version (block) manually. This allows editing generated files directly through the API.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.VersionDetail>> ChatsUpdateVersionAsResponseAsync(
            string chatId,
            string versionId,

            global::V0.ChatsUpdateVersionRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Chat Version Files<br/>
        /// Updates the source files of a specific chat version (block) manually. This allows editing generated files directly through the API.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId"></param>
        /// <param name="files">
        /// Array of files to update with their new content
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.VersionDetail> ChatsUpdateVersionAsync(
            string chatId,
            string versionId,
            global::System.Collections.Generic.IList<global::V0.ChatsUpdateVersionRequestFile> files,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}