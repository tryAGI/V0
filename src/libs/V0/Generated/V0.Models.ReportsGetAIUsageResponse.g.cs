
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportsGetAIUsageResponse
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
        public required global::System.Collections.Generic.IList<global::V0.ReportsGetAIUsageResponseDataItem> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ReportsGetAIUsageResponsePagination Pagination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateRange")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ReportsGetAIUsageResponseDateRange DateRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetAIUsageResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="pagination"></param>
        /// <param name="dateRange"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportsGetAIUsageResponse(
            global::System.Collections.Generic.IList<global::V0.ReportsGetAIUsageResponseDataItem> data,
            global::V0.ReportsGetAIUsageResponsePagination pagination,
            global::V0.ReportsGetAIUsageResponseDateRange dateRange,
            string @object = "list")
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.DateRange = dateRange ?? throw new global::System.ArgumentNullException(nameof(dateRange));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetAIUsageResponse" /> class.
        /// </summary>
        public ReportsGetAIUsageResponse()
        {
        }

    }
}