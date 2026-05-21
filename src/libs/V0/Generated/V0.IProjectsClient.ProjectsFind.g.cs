#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Find Projects<br/>
        /// Returns a list of all v0 projects in your workspace. Useful for browsing or managing projects across different chats or use cases.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsFindResponse> ProjectsFindAsync(
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find Projects<br/>
        /// Returns a list of all v0 projects in your workspace. Useful for browsing or managing projects across different chats or use cases.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ProjectsFindResponse>> ProjectsFindAsResponseAsync(
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}