#nullable enable

namespace V0
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Find Deployment Logs<br/>
        /// Retrieves logs for a specific deployment. Supports filtering by timestamp to fetch only recent logs.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="since">
        /// A UNIX timestamp (in seconds) used to filter logs. Returns only log entries generated after the specified time.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.DeploymentsFindLogsResponse> DeploymentsFindLogsAsync(
            string deploymentId,
            double? since = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}