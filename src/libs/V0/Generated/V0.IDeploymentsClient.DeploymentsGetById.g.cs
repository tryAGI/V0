#nullable enable

namespace V0
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Get Deployment<br/>
        /// Get a deployment by ID. This will return the details of the deployment, including the inspector URL, chat ID, project ID, version ID, API URL, and web URL.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.DeploymentDetail> DeploymentsGetByIdAsync(
            string deploymentId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}