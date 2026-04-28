#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Delete Chat Version Files<br/>
        /// Deletes source files from a specific chat version (block). Files are removed from the version and a new source version is created.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.VersionDetail> ChatsDeleteVersionFilesAsync(
            string chatId,
            string versionId,

            global::V0.ChatsDeleteVersionFilesRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Chat Version Files<br/>
        /// Deletes source files from a specific chat version (block). Files are removed from the version and a new source version is created.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId"></param>
        /// <param name="filePaths">
        /// Array of file paths to delete (e.g., ["components/test.tsx", "lib/utils.ts"])
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.VersionDetail> ChatsDeleteVersionFilesAsync(
            string chatId,
            string versionId,
            global::System.Collections.Generic.IList<string> filePaths,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}