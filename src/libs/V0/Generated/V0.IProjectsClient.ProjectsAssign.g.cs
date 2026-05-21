#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Assign Project to Chat<br/>
        /// Links an existing v0 project to a specific chat. Helps group conversations under a shared project context.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsAssignResponse> ProjectsAssignAsync(
            string projectId,

            global::V0.ProjectsAssignRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign Project to Chat<br/>
        /// Links an existing v0 project to a specific chat. Helps group conversations under a shared project context.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ProjectsAssignResponse>> ProjectsAssignAsResponseAsync(
            string projectId,

            global::V0.ProjectsAssignRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign Project to Chat<br/>
        /// Links an existing v0 project to a specific chat. Helps group conversations under a shared project context.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="chatId">
        /// The ID of the chat to assign the project to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectsAssignResponse> ProjectsAssignAsync(
            string projectId,
            string chatId,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}