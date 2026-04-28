#nullable enable

namespace V0
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Find Deployment Errors<br/>
        /// Retrieves a list of errors that occurred during a specific deployment. Useful for diagnosing and debugging deployment issues.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.DeploymentsFindErrorsResponse> DeploymentsFindErrorsAsync(
            string deploymentId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}