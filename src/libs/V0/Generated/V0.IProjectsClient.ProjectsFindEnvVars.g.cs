#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Find Environment Variables<br/>
        /// Retrieves all environment variables for a given project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="decrypted">
        /// Whether to return decrypted values. Defaults to false (encrypted).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsFindEnvVarsResponse> ProjectsFindEnvVarsAsync(
            string projectId,
            global::V0.ProjectsFindEnvVarsDecrypted? decrypted = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find Environment Variables<br/>
        /// Retrieves all environment variables for a given project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="decrypted">
        /// Whether to return decrypted values. Defaults to false (encrypted).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ProjectsFindEnvVarsResponse>> ProjectsFindEnvVarsAsResponseAsync(
            string projectId,
            global::V0.ProjectsFindEnvVarsDecrypted? decrypted = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}