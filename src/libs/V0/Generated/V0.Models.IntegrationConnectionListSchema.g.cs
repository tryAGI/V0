
#nullable enable

namespace V0
{
    /// <summary>
    /// List response containing integration connections.
    /// </summary>
    public sealed partial class IntegrationConnectionListSchema
    {
        /// <summary>
        /// Fixed value identifying this as a list response.
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// Array of integration connection summaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.IntegrationConnectionListSchemaDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationConnectionListSchema" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of integration connection summaries.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this as a list response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationConnectionListSchema(
            global::System.Collections.Generic.IList<global::V0.IntegrationConnectionListSchemaDataItem> data,
            string @object = "list")
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationConnectionListSchema" /> class.
        /// </summary>
        public IntegrationConnectionListSchema()
        {
        }

    }
}