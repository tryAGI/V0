#nullable enable

namespace V0
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Create Vercel Project<br/>
        /// Links a Vercel project to an existing v0 project. Enables Vercel-related features and deployment integration within the v0 workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.VercelProjectDetail> IntegrationsVercelProjectsCreateAsync(

            global::V0.IntegrationsVercelProjectsCreateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Vercel Project<br/>
        /// Links a Vercel project to an existing v0 project. Enables Vercel-related features and deployment integration within the v0 workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.VercelProjectDetail>> IntegrationsVercelProjectsCreateAsResponseAsync(

            global::V0.IntegrationsVercelProjectsCreateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Vercel Project<br/>
        /// Links a Vercel project to an existing v0 project. Enables Vercel-related features and deployment integration within the v0 workspace.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the v0 project to link to the new Vercel project.
        /// </param>
        /// <param name="name">
        /// The name to assign to the new Vercel project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.VercelProjectDetail> IntegrationsVercelProjectsCreateAsync(
            string projectId,
            string name,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}