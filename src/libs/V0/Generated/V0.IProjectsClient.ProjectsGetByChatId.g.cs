#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project by Chat ID<br/>
        /// Retrieves the v0 project associated with a given chat. Useful for determining the context or scope of a chat session.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectDetail> ProjectsGetByChatIdAsync(
            string chatId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}