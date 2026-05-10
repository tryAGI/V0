
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsInitRequest2
    {
        /// <summary>
        /// A user-defined name for the chat. Helps identify or describe the purpose of the chat session in the UI or API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Controls the visibility of the chat. Defines whether the chat is private, shared with a team, or publicly accessible.<br/>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatPrivacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsInitRequestChatPrivacyJsonConverter))]
        public global::V0.ChatsInitRequestChatPrivacy? ChatPrivacy { get; set; }

        /// <summary>
        /// Associates the chat with a specific project. Useful for organizing and grouping chats in a workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatsInitRequest2" /> class.
        /// </summary>
        /// <param name="name">
        /// A user-defined name for the chat. Helps identify or describe the purpose of the chat session in the UI or API responses.
        /// </param>
        /// <param name="chatPrivacy">
        /// Controls the visibility of the chat. Defines whether the chat is private, shared with a team, or publicly accessible.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="projectId">
        /// Associates the chat with a specific project. Useful for organizing and grouping chats in a workspace.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value data to attach to the chat. Useful for storing additional data about the chat, such as external user IDs.<br/>
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsInitRequest2(
            string? name,
            global::V0.ChatsInitRequestChatPrivacy? chatPrivacy,
            string? projectId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name;
            this.ChatPrivacy = chatPrivacy;
            this.ProjectId = projectId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequest2" /> class.
        /// </summary>
        public ChatsInitRequest2()
        {
        }

    }
}