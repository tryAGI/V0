
#nullable enable

namespace V0
{
    /// <summary>
    /// Full configuration details for a webhook, including its scope and subscription.
    /// </summary>
    public sealed partial class HookDetail
    {
        /// <summary>
        /// A unique identifier for the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fixed value identifying this object as a webhook.
        /// </summary>
        /// <default>"hook"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "hook";

        /// <summary>
        /// A user-defined name to label the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// List of event types this webhook is subscribed to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.HookDetailEvent> Events { get; set; }

        /// <summary>
        /// Optional ID of the chat that this webhook is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatId")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Target URL that receives event payloads for this webhook.
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
        /// Initializes a new instance of the <see cref="HookDetail" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the webhook.
        /// </param>
        /// <param name="name">
        /// A user-defined name to label the webhook.
        /// </param>
        /// <param name="events">
        /// List of event types this webhook is subscribed to.
        /// </param>
        /// <param name="url">
        /// Target URL that receives event payloads for this webhook.
        /// </param>
        /// <param name="chatId">
        /// Optional ID of the chat that this webhook is scoped to.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a webhook.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HookDetail(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::V0.HookDetailEvent> events,
            string url,
            string? chatId,
            string @object = "hook")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.ChatId = chatId;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HookDetail" /> class.
        /// </summary>
        public HookDetail()
        {
        }
    }
}