#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Send Message<br/>
        /// Creates a new message in an existing chat. Triggers a model response using the provided prompt, with optional attachments and configuration settings.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsSendMessageAsync(
            string chatId,

            global::V0.ChatsSendMessageRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send Message<br/>
        /// Creates a new message in an existing chat. Triggers a model response using the provided prompt, with optional attachments and configuration settings.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ChatDetail>> ChatsSendMessageAsResponseAsync(
            string chatId,

            global::V0.ChatsSendMessageRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send Message<br/>
        /// Creates a new message in an existing chat. Triggers a model response using the provided prompt, with optional attachments and configuration settings.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="message">
        /// The prompt or instruction to send to the model as part of the chat.
        /// </param>
        /// <param name="attachments">
        /// A list of files or assets to include with the message.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="system">
        /// Provides system-level context or background for the chat. This is typically used to specify frameworks, tools, or development environments relevant to the task.
        /// </param>
        /// <param name="modelConfiguration">
        /// Overrides for the model behavior.
        /// </param>
        /// <param name="responseMode">
        /// Controls how the response is delivered.<br/>
        /// - `"sync"`: The response is returned immediately with the HTTP request.<br/>
        /// - `"async"`: Returns a message placeholder immediately; use getById to poll for completion status and final output.<br/>
        /// - `"experimental_stream"`: Returns content parts as Server-Sent Events for real-time streaming.<br/>
        /// Default Value: sync
        /// </param>
        /// <param name="mcpServerIds">
        /// Array of MCP server IDs to enable for this message. When provided, only the specified servers will be used. When omitted, falls back to the user's enabled MCP servers.
        /// </param>
        /// <param name="attachedSkillIds">
        /// Array of skill IDs (from skills.sh) to attach to this message. Backwards-compatible alias for `skills` entries of type `remote`. Maximum 3 skills per chat.
        /// </param>
        /// <param name="skills">
        /// Skills to force-attach to this message. Supports skills.sh (`remote`), user/team memory (`memory`), and project (`project`) skills. Merged with `attachedSkillIds`. Maximum 3 skills per chat.
        /// </param>
        /// <param name="action">
        /// An optional action to perform. Use `fix-with-v0` to trigger automatic error fixing — the message should contain the error logs or context to fix.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsSendMessageAsync(
            string chatId,
            string message,
            global::System.Collections.Generic.IList<global::V0.ChatsSendMessageRequestAttachment>? attachments = default,
            string? system = default,
            global::V0.ChatsSendMessageRequestModelConfiguration? modelConfiguration = default,
            global::V0.ChatsSendMessageRequestResponseMode? responseMode = default,
            global::System.Collections.Generic.IList<string>? mcpServerIds = default,
            global::System.Collections.Generic.IList<string>? attachedSkillIds = default,
            global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsSendMessageRequestSkillVariant1, global::V0.ChatsSendMessageRequestSkillVariant2, global::V0.ChatsSendMessageRequestSkillVariant3>>? skills = default,
            global::V0.ChatsSendMessageRequestAction? action = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}