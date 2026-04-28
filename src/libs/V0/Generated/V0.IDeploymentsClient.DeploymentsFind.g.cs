#nullable enable

namespace V0
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Find Deployments<br/>
        /// Find deployments by project and chat IDs. This will return a list of deployments for the given project and chat IDs.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to find deployments for
        /// </param>
        /// <param name="chatId">
        /// The ID of the chat to find deployments for
        /// </param>
        /// <param name="versionId">
        /// The ID of the version to find deployments for
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.DeploymentsFindResponse> DeploymentsFindAsync(
            string projectId,
            string chatId,
            string versionId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}