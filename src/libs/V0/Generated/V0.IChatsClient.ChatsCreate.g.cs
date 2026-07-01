#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Create Chat<br/>
        /// Creates a new chat using a user message, optional system context, and model configuration. Useful for prompting the model within the scope of a specific project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsCreateAsync(

            global::V0.ChatsCreateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat<br/>
        /// Creates a new chat using a user message, optional system context, and model configuration. Useful for prompting the model within the scope of a specific project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ChatDetail>> ChatsCreateAsResponseAsync(

            global::V0.ChatsCreateRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat<br/>
        /// Creates a new chat using a user message, optional system context, and model configuration. Useful for prompting the model within the scope of a specific project.
        /// </summary>
        /// <param name="message">
        /// Creates a new chat using a user message, optional system context, and model configuration. Useful for prompting the model within the scope of a specific project.
        /// </param>
        /// <param name="attachments">
        /// A list of files or assets to be included in the conversation context. Useful when the chat or task requires referencing documents, images, or other resources.
        /// </param>
        /// <param name="system">
        /// Provides system-level context or background for the chat. This is typically used to specify frameworks, tools, or development environments relevant to the task.
        /// </param>
        /// <param name="chatPrivacy">
        /// Determines the privacy setting of the chat. This can control whether the chat is visible only to the user, to team members, or is public.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="projectId">
        /// Associates the chat with a specific project in your workspace. Helps organize and group related chats under a common project context.
        /// </param>
        /// <param name="modelConfiguration">
        /// Settings that control how the model behaves in the chat.
        /// </param>
        /// <param name="responseMode">
        /// Controls how the response is delivered.<br/>
        /// - `"sync"`: The response is returned immediately with the HTTP request.<br/>
        /// - `"async"`: Returns a message placeholder immediately; use getById to poll for completion status and final output.<br/>
        /// - `"experimental_stream"`: Returns content parts as Server-Sent Events for real-time streaming.<br/>
        /// Default Value: sync
        /// </param>
        /// <param name="designSystemId">
        /// The ID of a design system to apply to this chat. Design systems provide consistent styling and components for generated UI.
        /// </param>
        /// <param name="mcpServerIds">
        /// Array of MCP server IDs to enable for this chat. When provided, only the specified servers will be used. When omitted, falls back to the user's enabled MCP servers.
        /// </param>
        /// <param name="attachedSkillIds">
        /// Array of skill IDs (from skills.sh) to attach to this chat. Backwards-compatible alias for `skills` entries of type `remote`. Maximum 3 skills per chat.
        /// </param>
        /// <param name="skills">
        /// Skills to force-attach to this chat. Supports skills.sh (`remote`), user/team memory (`memory`), and project (`project`) skills. Merged with `attachedSkillIds`. Maximum 3 skills per chat.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value data to attach to the chat. Useful for storing additional data about the chat, such as external user IDs.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsCreateAsync(
            string message,
            global::System.Collections.Generic.IList<global::V0.ChatsCreateRequestAttachment>? attachments = default,
            string? system = default,
            global::V0.ChatsCreateRequestChatPrivacy? chatPrivacy = default,
            string? projectId = default,
            global::V0.ChatsCreateRequestModelConfiguration? modelConfiguration = default,
            global::V0.ChatsCreateRequestResponseMode? responseMode = default,
            string? designSystemId = default,
            global::System.Collections.Generic.IList<string>? mcpServerIds = default,
            global::System.Collections.Generic.IList<string>? attachedSkillIds = default,
            global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>>? skills = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}