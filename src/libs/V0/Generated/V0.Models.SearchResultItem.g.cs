
#nullable enable

namespace V0
{
    /// <summary>
    /// Generic result returned from a search query, representing either a chat or a project.
    /// </summary>
    public sealed partial class SearchResultItem
    {
        /// <summary>
        /// The unique ID of the item returned in the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type of item returned, either 'chat' or 'project'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.SearchResultItemObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.SearchResultItemObject Object { get; set; }

        /// <summary>
        /// The display name of the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ISO timestamp representing when the item was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ISO timestamp of the last update to the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// API endpoint for accessing the item programmatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiUrl { get; set; }

        /// <summary>
        /// Web URL for viewing the item in the interface.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the item returned in the search result.
        /// </param>
        /// <param name="object">
        /// Type of item returned, either 'chat' or 'project'.
        /// </param>
        /// <param name="name">
        /// The display name of the item.
        /// </param>
        /// <param name="createdAt">
        /// The ISO timestamp representing when the item was created.
        /// </param>
        /// <param name="apiUrl">
        /// API endpoint for accessing the item programmatically.
        /// </param>
        /// <param name="webUrl">
        /// Web URL for viewing the item in the interface.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO timestamp of the last update to the item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultItem(
            string id,
            global::V0.SearchResultItemObject @object,
            string name,
            global::System.DateTime createdAt,
            string apiUrl,
            string webUrl,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ApiUrl = apiUrl ?? throw new global::System.ArgumentNullException(nameof(apiUrl));
            this.WebUrl = webUrl ?? throw new global::System.ArgumentNullException(nameof(webUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultItem" /> class.
        /// </summary>
        public SearchResultItem()
        {
        }

    }
}