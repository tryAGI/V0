
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsSendMessageRequest
    {
        /// <summary>
        /// The prompt or instruction to send to the model as part of the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// A list of files or assets to include with the message.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::V0.ChatsSendMessageRequestAttachment>? Attachments { get; set; }

        /// <summary>
        /// Provides system-level context or background for the chat. This is typically used to specify frameworks, tools, or development environments relevant to the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public string? System { get; set; }

        /// <summary>
        /// Overrides for the model behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelConfiguration")]
        public global::V0.ChatsSendMessageRequestModelConfiguration? ModelConfiguration { get; set; }

        /// <summary>
        /// Controls how the response is delivered.<br/>
        /// - `"sync"`: The response is returned immediately with the HTTP request.<br/>
        /// - `"async"`: Returns a message placeholder immediately; use getById to poll for completion status and final output.<br/>
        /// - `"experimental_stream"`: Returns content parts as Server-Sent Events for real-time streaming.<br/>
        /// Default Value: sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsSendMessageRequestResponseModeJsonConverter))]
        public global::V0.ChatsSendMessageRequestResponseMode? ResponseMode { get; set; }

        /// <summary>
        /// Array of MCP server IDs to enable for this message. When provided, only the specified servers will be used. When omitted, falls back to the user's enabled MCP servers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServerIds")]
        public global::System.Collections.Generic.IList<string>? McpServerIds { get; set; }

        /// <summary>
        /// Array of skill IDs (from skills.sh) to attach to this message. Skills provide domain-specific knowledge and instructions that guide the AI. Maximum 3 skills per chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachedSkillIds")]
        public global::System.Collections.Generic.IList<string>? AttachedSkillIds { get; set; }

        /// <summary>
        /// An optional action to perform. Use `fix-with-v0` to trigger automatic error fixing — the message should contain the error logs or context to fix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::V0.ChatsSendMessageRequestAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsSendMessageRequest" /> class.
        /// </summary>
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
        /// Array of skill IDs (from skills.sh) to attach to this message. Skills provide domain-specific knowledge and instructions that guide the AI. Maximum 3 skills per chat.
        /// </param>
        /// <param name="action">
        /// An optional action to perform. Use `fix-with-v0` to trigger automatic error fixing — the message should contain the error logs or context to fix.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsSendMessageRequest(
            string message,
            global::System.Collections.Generic.IList<global::V0.ChatsSendMessageRequestAttachment>? attachments,
            string? system,
            global::V0.ChatsSendMessageRequestModelConfiguration? modelConfiguration,
            global::V0.ChatsSendMessageRequestResponseMode? responseMode,
            global::System.Collections.Generic.IList<string>? mcpServerIds,
            global::System.Collections.Generic.IList<string>? attachedSkillIds,
            global::V0.ChatsSendMessageRequestAction? action)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Attachments = attachments;
            this.System = system;
            this.ModelConfiguration = modelConfiguration;
            this.ResponseMode = responseMode;
            this.McpServerIds = mcpServerIds;
            this.AttachedSkillIds = attachedSkillIds;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsSendMessageRequest" /> class.
        /// </summary>
        public ChatsSendMessageRequest()
        {
        }
    }
}