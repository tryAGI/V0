
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageSummaryListDataItemAttachment
    {
        /// <summary>
        /// The URL where the attachment file can be accessed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The original filename of the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The MIME type of the attachment file (e.g., image/png, application/pdf).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The size of the attachment file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// The base64-encoded content of the attachment file, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Optional v0-specific attachment type for enhanced processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.MessageSummaryListDataItemAttachmentTypeJsonConverter))]
        public global::V0.MessageSummaryListDataItemAttachmentType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSummaryListDataItemAttachment" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL where the attachment file can be accessed.
        /// </param>
        /// <param name="size">
        /// The size of the attachment file in bytes.
        /// </param>
        /// <param name="name">
        /// The original filename of the attachment.
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the attachment file (e.g., image/png, application/pdf).
        /// </param>
        /// <param name="content">
        /// The base64-encoded content of the attachment file, if available.
        /// </param>
        /// <param name="type">
        /// Optional v0-specific attachment type for enhanced processing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageSummaryListDataItemAttachment(
            string url,
            double size,
            string? name,
            string? contentType,
            string? content,
            global::V0.MessageSummaryListDataItemAttachmentType? type)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Name = name;
            this.ContentType = contentType;
            this.Size = size;
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSummaryListDataItemAttachment" /> class.
        /// </summary>
        public MessageSummaryListDataItemAttachment()
        {
        }
    }
}