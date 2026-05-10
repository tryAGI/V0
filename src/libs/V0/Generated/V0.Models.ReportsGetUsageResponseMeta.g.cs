
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportsGetUsageResponseMeta
    {
        /// <summary>
        /// Number of events in this response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUsageResponseMeta" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// Number of events in this response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportsGetUsageResponseMeta(
            double totalCount)
        {
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUsageResponseMeta" /> class.
        /// </summary>
        public ReportsGetUsageResponseMeta()
        {
        }

    }
}