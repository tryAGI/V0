#nullable enable

namespace V0
{
    public partial interface IHooksClient
    {
        /// <summary>
        /// Delete Hook<br/>
        /// Deletes a webhook based on its ID. This action is irreversible.
        /// </summary>
        /// <param name="hookId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.HooksDeleteResponse> HooksDeleteAsync(
            string hookId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Hook<br/>
        /// Deletes a webhook based on its ID. This action is irreversible.
        /// </summary>
        /// <param name="hookId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.HooksDeleteResponse>> HooksDeleteAsResponseAsync(
            string hookId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}