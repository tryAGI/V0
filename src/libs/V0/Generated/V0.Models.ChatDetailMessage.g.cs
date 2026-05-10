
#nullable enable

namespace V0
{
    /// <summary>
    /// Summary of a single message within a chat, including role, content, type, timestamp, and API URL.
    /// </summary>
    public sealed partial class ChatDetailMessage
    {
        /// <summary>
        /// A unique identifier for the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fixed value identifying this object as a message.
        /// </summary>
        /// <default>"message"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "message";

        /// <summary>
        /// The main text content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The parsed content of the message as an array structure containing AST nodes. This is an experimental field that may change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental_content")]
        public global::System.Collections.Generic.IList<byte[]>? ExperimentalContent { get; set; }

        /// <summary>
        /// The ISO timestamp representing when the message was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The ISO timestamp representing when the message was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Indicates the format or category of the message, such as plain text or code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatDetailMessageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ChatDetailMessageType Type { get; set; }

        /// <summary>
        /// Specifies whether the message was sent by the user or the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatDetailMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ChatDetailMessageRole Role { get; set; }

        /// <summary>
        /// The reason why the message generation finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatDetailMessageFinishReasonJsonConverter))]
        public global::V0.ChatDetailMessageFinishReason? FinishReason { get; set; }

        /// <summary>
        /// API URL to access this message via the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiUrl { get; set; }

        /// <summary>
        /// The ID of the user who sent the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorId")]
        public string? AuthorId { get; set; }

        /// <summary>
        /// The ID of the parent message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::V0.ChatDetailMessageAttachment>? Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDetailMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the message.
        /// </param>
        /// <param name="content">
        /// The main text content of the message.
        /// </param>
        /// <param name="createdAt">
        /// The ISO timestamp representing when the message was created.
        /// </param>
        /// <param name="type">
        /// Indicates the format or category of the message, such as plain text or code.
        /// </param>
        /// <param name="role">
        /// Specifies whether the message was sent by the user or the assistant.
        /// </param>
        /// <param name="apiUrl">
        /// API URL to access this message via the API.
        /// </param>
        /// <param name="experimentalContent">
        /// The parsed content of the message as an array structure containing AST nodes. This is an experimental field that may change.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO timestamp representing when the message was last updated.
        /// </param>
        /// <param name="finishReason">
        /// The reason why the message generation finished.
        /// </param>
        /// <param name="authorId">
        /// The ID of the user who sent the message.
        /// </param>
        /// <param name="parentId">
        /// The ID of the parent message.
        /// </param>
        /// <param name="attachments"></param>
        /// <param name="object">
        /// Fixed value identifying this object as a message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatDetailMessage(
            string id,
            string content,
            string createdAt,
            global::V0.ChatDetailMessageType type,
            global::V0.ChatDetailMessageRole role,
            string apiUrl,
            global::System.Collections.Generic.IList<byte[]>? experimentalContent,
            global::System.DateTime? updatedAt,
            global::V0.ChatDetailMessageFinishReason? finishReason,
            string? authorId,
            string? parentId,
            global::System.Collections.Generic.IList<global::V0.ChatDetailMessageAttachment>? attachments,
            string @object = "message")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ExperimentalContent = experimentalContent;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt;
            this.Type = type;
            this.Role = role;
            this.FinishReason = finishReason;
            this.ApiUrl = apiUrl ?? throw new global::System.ArgumentNullException(nameof(apiUrl));
            this.AuthorId = authorId;
            this.ParentId = parentId;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDetailMessage" /> class.
        /// </summary>
        public ChatDetailMessage()
        {
        }

    }
}