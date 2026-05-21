
#nullable enable

namespace V0
{
    /// <summary>
    /// Detailed record of a webhook event, including its type, status, and timestamp.
    /// </summary>
    public sealed partial class HookEventDetail
    {
        /// <summary>
        /// A unique identifier for the webhook event log entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fixed value identifying this object as a webhook event.
        /// </summary>
        /// <default>"hook_event"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "hook_event";

        /// <summary>
        /// The type of event that triggered the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.HookEventDetailEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.HookEventDetailEvent Event { get; set; }

        /// <summary>
        /// The delivery status of the webhook (e.g., delivered, failed).<br/>
        /// Default Value: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.HookEventDetailStatusJsonConverter))]
        public global::V0.HookEventDetailStatus? Status { get; set; }

        /// <summary>
        /// Timestamp of when the webhook event was triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HookEventDetail" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the webhook event log entry.
        /// </param>
        /// <param name="event">
        /// The type of event that triggered the webhook.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the webhook event was triggered.
        /// </param>
        /// <param name="status">
        /// The delivery status of the webhook (e.g., delivered, failed).<br/>
        /// Default Value: pending
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a webhook event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HookEventDetail(
            string id,
            global::V0.HookEventDetailEvent @event,
            global::System.DateTime createdAt,
            global::V0.HookEventDetailStatus? status,
            string @object = "hook_event")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Event = @event;
            this.Status = status;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HookEventDetail" /> class.
        /// </summary>
        public HookEventDetail()
        {
        }

    }
}