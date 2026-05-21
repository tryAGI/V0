#nullable enable

namespace V0
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Get AI Usage Report<br/>
        /// Retrieves v0 AI usage events for the authenticated user or active team scope.
        /// </summary>
        /// <param name="start">
        /// Inclusive start datetime filter.
        /// </param>
        /// <param name="end">
        /// Exclusive end datetime filter.
        /// </param>
        /// <param name="cursor">
        /// Opaque cursor returned by a previous request for forward pagination.
        /// </param>
        /// <param name="limit">
        /// Maximum number of rows to return.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ReportsGetAIUsageResponse> ReportsGetAIUsageAsync(
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            string? cursor = default,
            int? limit = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get AI Usage Report<br/>
        /// Retrieves v0 AI usage events for the authenticated user or active team scope.
        /// </summary>
        /// <param name="start">
        /// Inclusive start datetime filter.
        /// </param>
        /// <param name="end">
        /// Exclusive end datetime filter.
        /// </param>
        /// <param name="cursor">
        /// Opaque cursor returned by a previous request for forward pagination.
        /// </param>
        /// <param name="limit">
        /// Maximum number of rows to return.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ReportsGetAIUsageResponse>> ReportsGetAIUsageAsResponseAsync(
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            string? cursor = default,
            int? limit = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}