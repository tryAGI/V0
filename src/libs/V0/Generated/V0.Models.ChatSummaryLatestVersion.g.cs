
#nullable enable

namespace V0
{
    /// <summary>
    /// The most recent generated version of the chat, if available.
    /// </summary>
    public sealed partial class ChatSummaryLatestVersion
    {
        /// <summary>
        /// A unique identifier for the version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fixed value identifying this object as a version.
        /// </summary>
        /// <default>"version"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "version";

        /// <summary>
        /// The current status of the version generation process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatSummaryLatestVersionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ChatSummaryLatestVersionStatus Status { get; set; }

        /// <summary>
        /// Optional URL for previewing the generated output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("demoUrl")]
        public string? DemoUrl { get; set; }

        /// <summary>
        /// URL to retrieve a screenshot of this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshotUrl")]
        public string? ScreenshotUrl { get; set; }

        /// <summary>
        /// The date and time when the version was created, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the version was last updated, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSummaryLatestVersion" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the version.
        /// </param>
        /// <param name="status">
        /// The current status of the version generation process.
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the version was created, in ISO 8601 format.
        /// </param>
        /// <param name="demoUrl">
        /// Optional URL for previewing the generated output.
        /// </param>
        /// <param name="screenshotUrl">
        /// URL to retrieve a screenshot of this version.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time when the version was last updated, in ISO 8601 format.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSummaryLatestVersion(
            string id,
            global::V0.ChatSummaryLatestVersionStatus status,
            global::System.DateTime createdAt,
            string? demoUrl,
            string? screenshotUrl,
            global::System.DateTime? updatedAt,
            string @object = "version")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Status = status;
            this.DemoUrl = demoUrl;
            this.ScreenshotUrl = screenshotUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSummaryLatestVersion" /> class.
        /// </summary>
        public ChatSummaryLatestVersion()
        {
        }

    }
}