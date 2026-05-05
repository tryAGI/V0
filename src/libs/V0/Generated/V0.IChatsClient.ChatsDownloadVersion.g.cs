#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Download version files<br/>
        /// Download all files for a specific chat version as a zip or tarball archive. Use includeDefaultFiles=true to include all deployment files (package.json, configuration files, etc.) or false/omitted to return only the generated source files.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId"></param>
        /// <param name="format">
        /// The archive format for the download. Choose "zip" for broad compatibility or "tarball" for Unix/Linux systems.<br/>
        /// Default Value: zip
        /// </param>
        /// <param name="includeDefaultFiles">
        /// When true, includes all default files (package.json, configuration files, etc.) that would be part of a complete deployment. When false or omitted, returns only the generated source files.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ChatsDownloadVersionAsync(
            string chatId,
            string versionId,
            global::V0.ChatsDownloadVersionFormat? format = default,
            global::V0.ChatsDownloadVersionIncludeDefaultFiles? includeDefaultFiles = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download version files<br/>
        /// Download all files for a specific chat version as a zip or tarball archive. Use includeDefaultFiles=true to include all deployment files (package.json, configuration files, etc.) or false/omitted to return only the generated source files.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId"></param>
        /// <param name="format">
        /// The archive format for the download. Choose "zip" for broad compatibility or "tarball" for Unix/Linux systems.<br/>
        /// Default Value: zip
        /// </param>
        /// <param name="includeDefaultFiles">
        /// When true, includes all default files (package.json, configuration files, etc.) that would be part of a complete deployment. When false or omitted, returns only the generated source files.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ChatsDownloadVersionAsStreamAsync(
            string chatId,
            string versionId,
            global::V0.ChatsDownloadVersionFormat? format = default,
            global::V0.ChatsDownloadVersionIncludeDefaultFiles? includeDefaultFiles = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download version files<br/>
        /// Download all files for a specific chat version as a zip or tarball archive. Use includeDefaultFiles=true to include all deployment files (package.json, configuration files, etc.) or false/omitted to return only the generated source files.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="versionId"></param>
        /// <param name="format">
        /// The archive format for the download. Choose "zip" for broad compatibility or "tarball" for Unix/Linux systems.<br/>
        /// Default Value: zip
        /// </param>
        /// <param name="includeDefaultFiles">
        /// When true, includes all default files (package.json, configuration files, etc.) that would be part of a complete deployment. When false or omitted, returns only the generated source files.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<byte[]>> ChatsDownloadVersionAsResponseAsync(
            string chatId,
            string versionId,
            global::V0.ChatsDownloadVersionFormat? format = default,
            global::V0.ChatsDownloadVersionIncludeDefaultFiles? includeDefaultFiles = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}