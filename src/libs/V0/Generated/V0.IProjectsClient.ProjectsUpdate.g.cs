#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update Project<br/>
        /// Updates the metadata of an existing project using its `projectId`. Supports changes to the project name and privacy setting.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectDetail> ProjectsUpdateAsync(
            string projectId,

            global::V0.ProjectsUpdateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Updates the metadata of an existing project using its `projectId`. Supports changes to the project name and privacy setting.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ProjectDetail>> ProjectsUpdateAsResponseAsync(
            string projectId,

            global::V0.ProjectsUpdateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Updates the metadata of an existing project using its `projectId`. Supports changes to the project name and privacy setting.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// A new name to assign to the project. Helps with identification and organization.
        /// </param>
        /// <param name="description">
        /// A new description to assign to the project. Helps with identification and organization.
        /// </param>
        /// <param name="instructions">
        /// Guidance or goals that provide context for the model when working within the project.
        /// </param>
        /// <param name="privacy">
        /// The privacy setting for the project. For user accounts, this must be "private". For team/enterprise accounts, this can be either "private" or "team".
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectDetail> ProjectsUpdateAsync(
            string projectId,
            string? name = default,
            string? description = default,
            string? instructions = default,
            global::V0.ProjectsUpdateRequestPrivacy? privacy = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}