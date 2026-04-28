
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatDetailFile
    {
        /// <summary>
        /// Programming language used in the file (e.g., JavaScript, Python).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lang { get; set; }

        /// <summary>
        /// A key-value map of metadata associated with the file (e.g., path, type).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Meta { get; set; }

        /// <summary>
        /// The origin or identifier of the file source (e.g., path or upload label).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDetailFile" /> class.
        /// </summary>
        /// <param name="lang">
        /// Programming language used in the file (e.g., JavaScript, Python).
        /// </param>
        /// <param name="meta">
        /// A key-value map of metadata associated with the file (e.g., path, type).
        /// </param>
        /// <param name="source">
        /// The origin or identifier of the file source (e.g., path or upload label).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatDetailFile(
            string lang,
            global::System.Collections.Generic.Dictionary<string, string> meta,
            string source)
        {
            this.Lang = lang ?? throw new global::System.ArgumentNullException(nameof(lang));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDetailFile" /> class.
        /// </summary>
        public ChatDetailFile()
        {
        }
    }
}