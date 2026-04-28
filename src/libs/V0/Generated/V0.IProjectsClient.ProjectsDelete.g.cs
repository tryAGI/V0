#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete Project<br/>
        /// Deletes a specific project based on the provided projectId. This operation marks the project as deleted and is irreversible.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="deleteAllChats">
        /// If true, deletes all the chats associated with the given project ID. Deleting is permanent. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsDeleteResponse> ProjectsDeleteAsync(
            string projectId,
            global::V0.ProjectsDeleteDeleteAllChats? deleteAllChats = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}