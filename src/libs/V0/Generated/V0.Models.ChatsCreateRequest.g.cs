
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsCreateRequest
    {
        /// <summary>
        /// Creates a new chat using a user message, optional system context, and model configuration. Useful for prompting the model within the scope of a specific project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// A list of files or assets to be included in the conversation context. Useful when the chat or task requires referencing documents, images, or other resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::V0.ChatsCreateRequestAttachment>? Attachments { get; set; }

        /// <summary>
        /// Provides system-level context or background for the chat. This is typically used to specify frameworks, tools, or development environments relevant to the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public string? System { get; set; }

        /// <summary>
        /// Determines the privacy setting of the chat. This can control whether the chat is visible only to the user, to team members, or is public.<br/>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatPrivacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsCreateRequestChatPrivacyJsonConverter))]
        public global::V0.ChatsCreateRequestChatPrivacy? ChatPrivacy { get; set; }

        /// <summary>
        /// Associates the chat with a specific project in your workspace. Helps organize and group related chats under a common project context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Settings that control how the model behaves in the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelConfiguration")]
        public global::V0.ChatsCreateRequestModelConfiguration? ModelConfiguration { get; set; }

        /// <summary>
        /// Controls how the response is delivered.<br/>
        /// - `"sync"`: The response is returned immediately with the HTTP request.<br/>
        /// - `"async"`: Returns a message placeholder immediately; use getById to poll for completion status and final output.<br/>
        /// - `"experimental_stream"`: Returns content parts as Server-Sent Events for real-time streaming.<br/>
        /// Default Value: sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsCreateRequestResponseModeJsonConverter))]
        public global::V0.ChatsCreateRequestResponseMode? ResponseMode { get; set; }

        /// <summary>
        /// The ID of a design system to apply to this chat. Design systems provide consistent styling and components for generated UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("designSystemId")]
        public string? DesignSystemId { get; set; }

        /// <summary>
        /// Array of MCP server IDs to enable for this chat. When provided, only the specified servers will be used. When omitted, falls back to the user's enabled MCP servers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServerIds")]
        public global::System.Collections.Generic.IList<string>? McpServerIds { get; set; }

        /// <summary>
        /// Array of skill IDs (from skills.sh) to attach to this chat. Skills provide domain-specific knowledge and instructions that guide the AI. Maximum 3 skills per chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachedSkillIds")]
        public global::System.Collections.Generic.IList<string>? AttachedSkillIds { get; set; }

        /// <summary>
        /// Arbitrary key-value data to attach to the chat. Useful for storing additional data about the chat, such as external user IDs.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsCreateRequest" /> class.
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
        /// Array of skill IDs (from skills.sh) to attach to this chat. Skills provide domain-specific knowledge and instructions that guide the AI. Maximum 3 skills per chat.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value data to attach to the chat. Useful for storing additional data about the chat, such as external user IDs.<br/>
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsCreateRequest(
            string message,
            global::System.Collections.Generic.IList<global::V0.ChatsCreateRequestAttachment>? attachments,
            string? system,
            global::V0.ChatsCreateRequestChatPrivacy? chatPrivacy,
            string? projectId,
            global::V0.ChatsCreateRequestModelConfiguration? modelConfiguration,
            global::V0.ChatsCreateRequestResponseMode? responseMode,
            string? designSystemId,
            global::System.Collections.Generic.IList<string>? mcpServerIds,
            global::System.Collections.Generic.IList<string>? attachedSkillIds,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Attachments = attachments;
            this.System = system;
            this.ChatPrivacy = chatPrivacy;
            this.ProjectId = projectId;
            this.ModelConfiguration = modelConfiguration;
            this.ResponseMode = responseMode;
            this.DesignSystemId = designSystemId;
            this.McpServerIds = mcpServerIds;
            this.AttachedSkillIds = attachedSkillIds;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsCreateRequest" /> class.
        /// </summary>
        public ChatsCreateRequest()
        {
        }

    }
}