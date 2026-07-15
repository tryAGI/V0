
#nullable enable

namespace V0
{
    /// <summary>
    /// Summary information about a marketplace or store product.
    /// </summary>
    public sealed partial class ProductSummarySchema
    {
        /// <summary>
        /// The object type.
        /// </summary>
        /// <default>"product"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "product";

        /// <summary>
        /// The unique ID of the product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The URL-friendly slug of the product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A short description of the product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// URL to the product icon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IconUrl { get; set; }

        /// <summary>
        /// The product's availability in v0. 'in-review' products only appear for teams with the review view and should be rendered as such.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v0Availability")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ProductSummarySchemaV0AvailabilityJsonConverter))]
        public global::V0.ProductSummarySchemaV0Availability? V0Availability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSummarySchema" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the product.
        /// </param>
        /// <param name="slug">
        /// The URL-friendly slug of the product.
        /// </param>
        /// <param name="name">
        /// The name of the product.
        /// </param>
        /// <param name="description">
        /// A short description of the product.
        /// </param>
        /// <param name="iconUrl">
        /// URL to the product icon.
        /// </param>
        /// <param name="v0Availability">
        /// The product's availability in v0. 'in-review' products only appear for teams with the review view and should be rendered as such.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductSummarySchema(
            string id,
            string slug,
            string name,
            string description,
            string iconUrl,
            global::V0.ProductSummarySchemaV0Availability? v0Availability,
            string @object = "product")
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IconUrl = iconUrl ?? throw new global::System.ArgumentNullException(nameof(iconUrl));
            this.V0Availability = v0Availability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSummarySchema" /> class.
        /// </summary>
        public ProductSummarySchema()
        {
        }

    }
}