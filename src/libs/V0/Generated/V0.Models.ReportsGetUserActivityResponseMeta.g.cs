
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportsGetUserActivityResponseMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateRange")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ReportsGetUserActivityResponseMetaDateRange DateRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUserActivityResponseMeta" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="dateRange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportsGetUserActivityResponseMeta(
            double totalCount,
            global::V0.ReportsGetUserActivityResponseMetaDateRange dateRange)
        {
            this.TotalCount = totalCount;
            this.DateRange = dateRange ?? throw new global::System.ArgumentNullException(nameof(dateRange));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUserActivityResponseMeta" /> class.
        /// </summary>
        public ReportsGetUserActivityResponseMeta()
        {
        }
    }
}