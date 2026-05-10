
#nullable enable

namespace V0
{
    /// <summary>
    /// Summary of a webhook, including its ID and display name.
    /// </summary>
    public sealed partial class HookSummary
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HookSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the webhook.
        /// </param>
        /// <param name="name">
        /// A user-defined name to label the webhook.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a webhook.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HookSummary(
            string id,
            string name,
            string @object = "hook")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HookSummary" /> class.
        /// </summary>
        public HookSummary()
        {
        }

    }
}