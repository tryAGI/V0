
#nullable enable

namespace V0
{
    /// <summary>
    /// List response containing multiple version summaries with cursor-based pagination.
    /// </summary>
    public sealed partial class VersionSummaryList
    {
        /// <summary>
        /// Fixed value identifying this as a list response.
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// Array of version summaries in this page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.VersionSummaryListDataItem> Data { get; set; }

        /// <summary>
        /// Pagination metadata for navigating through multiple pages of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.VersionSummaryListPagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionSummaryList" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of version summaries in this page of results.
        /// </param>
        /// <param name="pagination">
        /// Pagination metadata for navigating through multiple pages of results.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this as a list response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VersionSummaryList(
            global::System.Collections.Generic.IList<global::V0.VersionSummaryListDataItem> data,
            global::V0.VersionSummaryListPagination pagination,
            string @object = "list")
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionSummaryList" /> class.
        /// </summary>
        public VersionSummaryList()
        {
        }

    }
}