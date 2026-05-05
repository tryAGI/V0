#nullable enable

namespace V0
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get Billing<br/>
        /// Fetches billing usage and quota information for the authenticated user. Can be scoped to a specific context (e.g. project or namespace).
        /// </summary>
        /// <param name="scope">
        /// Filters billing data by a specific scope, such as a project ID or slug.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AnyOf<global::V0.UserGetBillingResponseVariant1, global::V0.UserGetBillingResponseVariant2>> UserGetBillingAsync(
            string? scope = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Billing<br/>
        /// Fetches billing usage and quota information for the authenticated user. Can be scoped to a specific context (e.g. project or namespace).
        /// </summary>
        /// <param name="scope">
        /// Filters billing data by a specific scope, such as a project ID or slug.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.AnyOf<global::V0.UserGetBillingResponseVariant1, global::V0.UserGetBillingResponseVariant2>>> UserGetBillingAsResponseAsync(
            string? scope = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}