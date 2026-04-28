
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsFindMessagesResponsePagination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextUrl")]
        public string? NextUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsFindMessagesResponsePagination" /> class.
        /// </summary>
        /// <param name="hasMore"></param>
        /// <param name="nextCursor"></param>
        /// <param name="nextUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsFindMessagesResponsePagination(
            bool hasMore,
            string? nextCursor,
            string? nextUrl)
        {
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
            this.NextUrl = nextUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsFindMessagesResponsePagination" /> class.
        /// </summary>
        public ChatsFindMessagesResponsePagination()
        {
        }
    }
}