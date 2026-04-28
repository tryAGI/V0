
#nullable enable

namespace V0
{
    /// <summary>
    /// List of available integrations.
    /// </summary>
    public sealed partial class IntegrationListSchema
    {
        /// <summary>
        /// Fixed value identifying this as a list response.
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// Array of integration details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.IntegrationListSchemaDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationListSchema" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of integration details.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this as a list response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationListSchema(
            global::System.Collections.Generic.IList<global::V0.IntegrationListSchemaDataItem> data,
            string @object = "list")
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationListSchema" /> class.
        /// </summary>
        public IntegrationListSchema()
        {
        }
    }
}