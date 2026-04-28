
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportsGetUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.ReportsGetUsageResponseDataItem> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ReportsGetUsageResponsePagination Pagination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ReportsGetUsageResponseMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUsageResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="pagination"></param>
        /// <param name="meta"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportsGetUsageResponse(
            global::System.Collections.Generic.IList<global::V0.ReportsGetUsageResponseDataItem> data,
            global::V0.ReportsGetUsageResponsePagination pagination,
            global::V0.ReportsGetUsageResponseMeta meta,
            string @object = "list")
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUsageResponse" /> class.
        /// </summary>
        public ReportsGetUsageResponse()
        {
        }
    }
}