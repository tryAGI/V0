#nullable enable

namespace V0
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get User Scopes<br/>
        /// Retrieves all accessible scopes for the authenticated user, such as personal workspaces or shared teams.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.UserGetScopesResponse> UserGetScopesAsync(
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}