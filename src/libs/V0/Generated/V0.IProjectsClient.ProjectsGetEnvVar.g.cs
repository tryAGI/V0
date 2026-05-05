#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Environment Variable<br/>
        /// Retrieves a specific environment variable for a given project by its ID, including its value.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="environmentVariableId"></param>
        /// <param name="decrypted">
        /// Whether to return decrypted values. Defaults to false (encrypted).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsGetEnvVarResponse> ProjectsGetEnvVarAsync(
            string projectId,
            string environmentVariableId,
            global::V0.ProjectsGetEnvVarDecrypted? decrypted = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Environment Variable<br/>
        /// Retrieves a specific environment variable for a given project by its ID, including its value.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="environmentVariableId"></param>
        /// <param name="decrypted">
        /// Whether to return decrypted values. Defaults to false (encrypted).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ProjectsGetEnvVarResponse>> ProjectsGetEnvVarAsResponseAsync(
            string projectId,
            string environmentVariableId,
            global::V0.ProjectsGetEnvVarDecrypted? decrypted = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}