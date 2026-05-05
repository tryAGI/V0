#nullable enable

namespace V0
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Get User Activity Report<br/>
        /// Retrieves aggregated user activity data for team members, including chat counts, message counts, and activity timestamps. Only available for Enterprise teams with OWNER or BILLING role. Shows the same data as displayed in the Usage settings for Enterprise teams.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ReportsGetUserActivityResponse> ReportsGetUserActivityAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User Activity Report<br/>
        /// Retrieves aggregated user activity data for team members, including chat counts, message counts, and activity timestamps. Only available for Enterprise teams with OWNER or BILLING role. Shows the same data as displayed in the Usage settings for Enterprise teams.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ReportsGetUserActivityResponse>> ReportsGetUserActivityAsResponseAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}