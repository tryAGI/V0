#nullable enable

namespace V0
{
    public partial interface IHooksClient
    {
        /// <summary>
        /// Find Hooks<br/>
        /// Retrieves a list of existing hooks in your workspace. Useful for managing active webhooks tied to chat events or deployments.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.HooksFindResponse> HooksFindAsync(
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find Hooks<br/>
        /// Retrieves a list of existing hooks in your workspace. Useful for managing active webhooks tied to chat events or deployments.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.HooksFindResponse>> HooksFindAsResponseAsync(
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}