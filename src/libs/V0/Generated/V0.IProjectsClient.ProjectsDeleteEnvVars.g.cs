#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete Environment Variables<br/>
        /// Deletes multiple environment variables for a given project by their IDs.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsDeleteEnvVarsResponse> ProjectsDeleteEnvVarsAsync(
            string projectId,

            global::V0.ProjectsDeleteEnvVarsRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Environment Variables<br/>
        /// Deletes multiple environment variables for a given project by their IDs.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ProjectsDeleteEnvVarsResponse>> ProjectsDeleteEnvVarsAsResponseAsync(
            string projectId,

            global::V0.ProjectsDeleteEnvVarsRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Environment Variables<br/>
        /// Deletes multiple environment variables for a given project by their IDs.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="environmentVariableIds">
        /// An array of environment variable IDs to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsDeleteEnvVarsResponse> ProjectsDeleteEnvVarsAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> environmentVariableIds,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}