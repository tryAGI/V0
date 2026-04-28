#nullable enable

namespace V0
{
    public partial interface IHooksClient
    {
        /// <summary>
        /// Update Hook<br/>
        /// Updates the configuration of an existing webhook, including its name, event subscriptions, or target URL.
        /// </summary>
        /// <param name="hookId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.HookDetail> HooksUpdateAsync(
            string hookId,

            global::V0.HooksUpdateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Hook<br/>
        /// Updates the configuration of an existing webhook, including its name, event subscriptions, or target URL.
        /// </summary>
        /// <param name="hookId"></param>
        /// <param name="name">
        /// A new name for the hook.
        /// </param>
        /// <param name="events">
        /// Updated list of event types to subscribe to.
        /// </param>
        /// <param name="url">
        /// A new URL to send webhook payloads to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.HookDetail> HooksUpdateAsync(
            string hookId,
            string? name = default,
            global::System.Collections.Generic.IList<global::V0.HooksUpdateRequestEvent>? events = default,
            string? url = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}