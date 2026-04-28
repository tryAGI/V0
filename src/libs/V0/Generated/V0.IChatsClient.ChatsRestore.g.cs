#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Restore Block<br/>
        /// Restores a block to a specific version.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.VersionDetail> ChatsRestoreAsync(
            string chatId,
            string versionId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}