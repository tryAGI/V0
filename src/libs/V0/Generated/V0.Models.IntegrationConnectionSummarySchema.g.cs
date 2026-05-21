
#nullable enable

namespace V0
{
    /// <summary>
    /// Summary information about an integration connection to a project.
    /// </summary>
    public sealed partial class IntegrationConnectionSummarySchema
    {
        /// <summary>
        /// The object type.
        /// </summary>
        /// <default>"integration_connection"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "integration_connection";

        /// <summary>
        /// The unique ID of the integration connection (format: {projectId}_{integrationId}).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the integration is connected to the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Connected { get; set; }

        /// <summary>
        /// Information about the connected integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.IntegrationConnectionSummarySchemaIntegration Integration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationConnectionSummarySchema" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the integration connection (format: {projectId}_{integrationId}).
        /// </param>
        /// <param name="connected">
        /// Whether the integration is connected to the project.
        /// </param>
        /// <param name="integration">
        /// Information about the connected integration.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationConnectionSummarySchema(
            string id,
            bool connected,
            global::V0.IntegrationConnectionSummarySchemaIntegration integration,
            string @object = "integration_connection")
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Connected = connected;
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationConnectionSummarySchema" /> class.
        /// </summary>
        public IntegrationConnectionSummarySchema()
        {
        }

    }
}