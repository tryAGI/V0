
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsUpdateRequest
    {
        /// <summary>
        /// A new name to assign to the chat. Helps with identification and organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Sets the privacy level of the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsUpdateRequestPrivacyJsonConverter))]
        public global::V0.ChatsUpdateRequestPrivacy? Privacy { get; set; }

        /// <summary>
        /// Arbitrary key-value data to attach to the chat. Useful for storing additional data about the chat, such as external user IDs. Metadata added will be merged with existing attributes. Pass `null` as the value to delete a specific key, or pass `null` instead of an object to delete all existing metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A new name to assign to the chat. Helps with identification and organization.
        /// </param>
        /// <param name="privacy">
        /// Sets the privacy level of the chat.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value data to attach to the chat. Useful for storing additional data about the chat, such as external user IDs. Metadata added will be merged with existing attributes. Pass `null` as the value to delete a specific key, or pass `null` instead of an object to delete all existing metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsUpdateRequest(
            string? name,
            global::V0.ChatsUpdateRequestPrivacy? privacy,
            object? metadata)
        {
            this.Name = name;
            this.Privacy = privacy;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsUpdateRequest" /> class.
        /// </summary>
        public ChatsUpdateRequest()
        {
        }
    }
}