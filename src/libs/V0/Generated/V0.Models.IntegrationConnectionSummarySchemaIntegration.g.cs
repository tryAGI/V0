
#nullable enable

namespace V0
{
    /// <summary>
    /// Information about the connected integration.
    /// </summary>
    public sealed partial class IntegrationConnectionSummarySchemaIntegration
    {
        /// <summary>
        /// The ID of the integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        /// <default>"integration"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "integration";

        /// <summary>
        /// The slug of the integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The name of the integration.
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
        /// Initializes a new instance of the <see cref="IntegrationConnectionSummarySchemaIntegration" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the integration.
        /// </param>
        /// <param name="slug">
        /// The slug of the integration.
        /// </param>
        /// <param name="name">
        /// The name of the integration.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationConnectionSummarySchemaIntegration(
            string id,
            string slug,
            string name,
            string @object = "integration")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationConnectionSummarySchemaIntegration" /> class.
        /// </summary>
        public IntegrationConnectionSummarySchemaIntegration()
        {
        }

    }
}