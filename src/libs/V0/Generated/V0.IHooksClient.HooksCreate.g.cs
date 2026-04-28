#nullable enable

namespace V0
{
    public partial interface IHooksClient
    {
        /// <summary>
        /// Create Hook<br/>
        /// Creates a new webhook that listens for specific events. Supports optional association with a chat.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.HookDetail> HooksCreateAsync(

            global::V0.HooksCreateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Hook<br/>
        /// Creates a new webhook that listens for specific events. Supports optional association with a chat.
        /// </summary>
        /// <param name="name">
        /// A human-readable name for the hook.
        /// </param>
        /// <param name="events">
        /// List of event types the hook should subscribe to.
        /// </param>
        /// <param name="chatId">
        /// The ID of a chat to scope the hook to.
        /// </param>
        /// <param name="url">
        /// The target URL to receive the webhook payloads.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.HookDetail> HooksCreateAsync(
            string name,
            global::System.Collections.Generic.IList<global::V0.HooksCreateRequestEvent> events,
            string url,
            string? chatId = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}