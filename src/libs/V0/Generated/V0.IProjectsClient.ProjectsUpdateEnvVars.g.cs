#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update Environment Variables<br/>
        /// Updates multiple environment variables for a given project. Only the value of each environment variable can be updated.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="decrypted">
        /// Whether to return decrypted values. Defaults to false (encrypted).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsUpdateEnvVarsResponse> ProjectsUpdateEnvVarsAsync(
            string projectId,

            global::V0.ProjectsUpdateEnvVarsRequest request,
            global::V0.ProjectsUpdateEnvVarsDecrypted? decrypted = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Environment Variables<br/>
        /// Updates multiple environment variables for a given project. Only the value of each environment variable can be updated.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="decrypted">
        /// Whether to return decrypted values. Defaults to false (encrypted).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ProjectsUpdateEnvVarsResponse>> ProjectsUpdateEnvVarsAsResponseAsync(
            string projectId,

            global::V0.ProjectsUpdateEnvVarsRequest request,
            global::V0.ProjectsUpdateEnvVarsDecrypted? decrypted = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Environment Variables<br/>
        /// Updates multiple environment variables for a given project. Only the value of each environment variable can be updated.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="decrypted">
        /// Whether to return decrypted values. Defaults to false (encrypted).
        /// </param>
        /// <param name="environmentVariables">
        /// An array of environment variables to update with id and value fields.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsUpdateEnvVarsResponse> ProjectsUpdateEnvVarsAsync(
            string projectId,
            global::System.Collections.Generic.IList<global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable> environmentVariables,
            global::V0.ProjectsUpdateEnvVarsDecrypted? decrypted = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}