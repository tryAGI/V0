
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HooksCreateRequest
    {
        /// <summary>
        /// A human-readable name for the hook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// List of event types the hook should subscribe to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.HooksCreateRequestEvent> Events { get; set; }

        /// <summary>
        /// The ID of a chat to scope the hook to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatId")]
        public string? ChatId { get; set; }

        /// <summary>
        /// The target URL to receive the webhook payloads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HooksCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A human-readable name for the hook.
        /// </param>
        /// <param name="events">
        /// List of event types the hook should subscribe to.
        /// </param>
        /// <param name="url">
        /// The target URL to receive the webhook payloads.
        /// </param>
        /// <param name="chatId">
        /// The ID of a chat to scope the hook to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HooksCreateRequest(
            string name,
            global::System.Collections.Generic.IList<global::V0.HooksCreateRequestEvent> events,
            string url,
            string? chatId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.ChatId = chatId;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HooksCreateRequest" /> class.
        /// </summary>
        public HooksCreateRequest()
        {
        }

    }
}