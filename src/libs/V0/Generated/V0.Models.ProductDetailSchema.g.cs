
#nullable enable

namespace V0
{
    /// <summary>
    /// Detailed information about a marketplace or store product.
    /// </summary>
    public sealed partial class ProductDetailSchema
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
        /// Background color for the product icon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconBackgroundColor")]
        public string? IconBackgroundColor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailSchema" /> class.
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
        /// <param name="iconBackgroundColor">
        /// Background color for the product icon.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductDetailSchema(
            string id,
            string slug,
            string name,
            string description,
            string iconUrl,
            string? iconBackgroundColor,
            string @object = "product")
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IconUrl = iconUrl ?? throw new global::System.ArgumentNullException(nameof(iconUrl));
            this.IconBackgroundColor = iconBackgroundColor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailSchema" /> class.
        /// </summary>
        public ProductDetailSchema()
        {
        }

    }
}