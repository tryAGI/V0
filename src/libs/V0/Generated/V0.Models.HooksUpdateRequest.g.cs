
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HooksUpdateRequest
    {
        /// <summary>
        /// A new name for the hook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated list of event types to subscribe to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::V0.HooksUpdateRequestEvent>? Events { get; set; }

        /// <summary>
        /// A new URL to send webhook payloads to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HooksUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A new name for the hook.
        /// </param>
        /// <param name="events">
        /// Updated list of event types to subscribe to.
        /// </param>
        /// <param name="url">
        /// A new URL to send webhook payloads to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HooksUpdateRequest(
            string? name,
            global::System.Collections.Generic.IList<global::V0.HooksUpdateRequestEvent>? events,
            string? url)
        {
            this.Name = name;
            this.Events = events;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HooksUpdateRequest" /> class.
        /// </summary>
        public HooksUpdateRequest()
        {
        }

    }
}