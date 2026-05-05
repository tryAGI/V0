#nullable enable

namespace V0
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create Project<br/>
        /// Creates a new v0 project with an optional description, icon, environment variables, and instructions. Projects help organize chats and manage context.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectDetail> ProjectsCreateAsync(

            global::V0.ProjectsCreateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Project<br/>
        /// Creates a new v0 project with an optional description, icon, environment variables, and instructions. Projects help organize chats and manage context.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ProjectDetail>> ProjectsCreateAsResponseAsync(

            global::V0.ProjectsCreateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Project<br/>
        /// Creates a new v0 project with an optional description, icon, environment variables, and instructions. Projects help organize chats and manage context.
        /// </summary>
        /// <param name="name">
        /// The name of the project.
        /// </param>
        /// <param name="description">
        /// A brief summary of the project’s purpose.
        /// </param>
        /// <param name="icon">
        /// An icon identifier to visually represent the project.<br/>
        /// Default Value: icon-wand-sparkles
        /// </param>
        /// <param name="environmentVariables">
        /// A list of key-value pairs used to define runtime variables for the project.
        /// </param>
        /// <param name="instructions">
        /// Guidance or goals that provide context for the model when working within the project.
        /// </param>
        /// <param name="vercelProjectId">
        /// The ID of an existing Vercel project to link to. If not provided, a new Vercel project will be created.
        /// </param>
        /// <param name="privacy">
        /// The privacy setting for the project. For user accounts, this is always "private". For team/enterprise accounts, this can be either "private" or "team".
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ProjectDetail> ProjectsCreateAsync(
            string name,
            string? description = default,
            string? icon = default,
            global::System.Collections.Generic.IList<global::V0.ProjectsCreateRequestEnvironmentVariable>? environmentVariables = default,
            string? instructions = default,
            string? vercelProjectId = default,
            global::V0.ProjectsCreateRequestPrivacy? privacy = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}