#nullable enable

namespace V0
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Find Vercel Projects<br/>
        /// Retrieves a list of Vercel projects linked to your integration. Useful for associating chats, deployments, or hooks with specific Vercel projects.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.IntegrationsVercelProjectsFindResponse> IntegrationsVercelProjectsFindAsync(
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}