
#nullable enable

namespace V0
{
    /// <summary>
    /// Basic information about a workspace or identity context for projects and chats.
    /// </summary>
    public sealed partial class ScopeSummary
    {
        /// <summary>
        /// A unique identifier for the scope (e.g., user or team workspace).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fixed value identifying this object as a scope.
        /// </summary>
        /// <default>"scope"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "scope";

        /// <summary>
        /// An optional human-readable name for the scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the scope (e.g., user or team workspace).
        /// </param>
        /// <param name="name">
        /// An optional human-readable name for the scope.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a scope.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScopeSummary(
            string id,
            string? name,
            string @object = "scope")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeSummary" /> class.
        /// </summary>
        public ScopeSummary()
        {
        }
    }
}