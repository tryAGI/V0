#nullable enable

namespace V0
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Get Usage Report<br/>
        /// Retrieves detailed usage events for the authenticated user or team, including costs, event types, models used, and metadata. Shows the same data as displayed in the usage dashboard. Can be filtered by chatId to show usage for a specific chat, or by userId to show usage for a specific user.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="userId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Base64 encoded cursor containing pagination data
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ReportsGetUsageResponse> ReportsGetUsageAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? chatId = default,
            string? messageId = default,
            string? userId = default,
            double? limit = default,
            string? cursor = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Usage Report<br/>
        /// Retrieves detailed usage events for the authenticated user or team, including costs, event types, models used, and metadata. Shows the same data as displayed in the usage dashboard. Can be filtered by chatId to show usage for a specific chat, or by userId to show usage for a specific user.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="userId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Base64 encoded cursor containing pagination data
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ReportsGetUsageResponse>> ReportsGetUsageAsResponseAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? chatId = default,
            string? messageId = default,
            string? userId = default,
            double? limit = default,
            string? cursor = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}