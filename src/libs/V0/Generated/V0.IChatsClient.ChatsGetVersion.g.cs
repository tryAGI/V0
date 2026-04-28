#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Get Chat Version<br/>
        /// Retrieves detailed information about a specific version of a chat, including all files with their content and lock status.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId"></param>
        /// <param name="includeDefaultFiles">
        /// When true, includes all default files (package.json, configuration files, etc.) that would be part of a ZIP download. When false or omitted, returns only the generated source files.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.VersionDetail> ChatsGetVersionAsync(
            string chatId,
            string versionId,
            global::V0.ChatsGetVersionIncludeDefaultFiles? includeDefaultFiles = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}