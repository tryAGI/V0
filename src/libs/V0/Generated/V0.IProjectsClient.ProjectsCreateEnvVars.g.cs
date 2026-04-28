#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create Environment Variables<br/>
        /// Creates new environment variables for a given project. This endpoint will fail if any of the specified environment variable keys already exist, unless upsert is set to true.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="decrypted">
        /// Whether to return decrypted values. Defaults to false (encrypted).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsCreateEnvVarsResponse> ProjectsCreateEnvVarsAsync(
            string projectId,

            global::V0.ProjectsCreateEnvVarsRequest request,
            global::V0.ProjectsCreateEnvVarsDecrypted? decrypted = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Environment Variables<br/>
        /// Creates new environment variables for a given project. This endpoint will fail if any of the specified environment variable keys already exist, unless upsert is set to true.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="decrypted">
        /// Whether to return decrypted values. Defaults to false (encrypted).
        /// </param>
        /// <param name="environmentVariables">
        /// An array of environment variables to create with key and value fields.
        /// </param>
        /// <param name="upsert">
        /// Whether to overwrite existing environment variables with the same keys. Defaults to false.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsCreateEnvVarsResponse> ProjectsCreateEnvVarsAsync(
            string projectId,
            global::System.Collections.Generic.IList<global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable> environmentVariables,
            global::V0.ProjectsCreateEnvVarsDecrypted? decrypted = default,
            bool? upsert = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}