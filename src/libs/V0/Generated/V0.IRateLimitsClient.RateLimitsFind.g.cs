#nullable enable

namespace V0
{
    public partial interface IRateLimitsClient
    {
        /// <summary>
        /// Find Rate Limit<br/>
        /// Retrieves rate limit information for a given scope. Useful for monitoring usage limits and avoiding throttling.
        /// </summary>
        /// <param name="scope">
        /// The context or namespace to check rate limits for (e.g., a project slug or feature area).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.RateLimitsFindResponse> RateLimitsFindAsync(
            string? scope = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find Rate Limit<br/>
        /// Retrieves rate limit information for a given scope. Useful for monitoring usage limits and avoiding throttling.
        /// </summary>
        /// <param name="scope">
        /// The context or namespace to check rate limits for (e.g., a project slug or feature area).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.RateLimitsFindResponse>> RateLimitsFindAsResponseAsync(
            string? scope = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}