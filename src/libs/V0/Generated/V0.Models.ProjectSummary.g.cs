
#nullable enable

namespace V0
{
    /// <summary>
    /// Summary of a project, including metadata, timestamps, and optional Vercel linkage.
    /// </summary>
    public sealed partial class ProjectSummary
    {
        /// <summary>
        /// A unique identifier for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fixed value identifying this object as a project.
        /// </summary>
        /// <default>"project"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "project";

        /// <summary>
        /// The name of the project as defined by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The privacy setting for the project - either private or team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ProjectSummaryPrivacyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ProjectSummaryPrivacy Privacy { get; set; }

        /// <summary>
        /// Optional ID of the linked Vercel project, if connected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelProjectId")]
        public string? VercelProjectId { get; set; }

        /// <summary>
        /// The ISO timestamp representing when the project was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ISO timestamp of the most recent update, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The API endpoint URL for accessing this project programmatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiUrl { get; set; }

        /// <summary>
        /// The web URL where the project can be viewed or managed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the project.
        /// </param>
        /// <param name="name">
        /// The name of the project as defined by the user.
        /// </param>
        /// <param name="privacy">
        /// The privacy setting for the project - either private or team.
        /// </param>
        /// <param name="createdAt">
        /// The ISO timestamp representing when the project was created.
        /// </param>
        /// <param name="apiUrl">
        /// The API endpoint URL for accessing this project programmatically.
        /// </param>
        /// <param name="webUrl">
        /// The web URL where the project can be viewed or managed.
        /// </param>
        /// <param name="vercelProjectId">
        /// Optional ID of the linked Vercel project, if connected.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO timestamp of the most recent update, if available.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSummary(
            string id,
            string name,
            global::V0.ProjectSummaryPrivacy privacy,
            global::System.DateTime createdAt,
            string apiUrl,
            string webUrl,
            string? vercelProjectId,
            global::System.DateTime? updatedAt,
            string @object = "project")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Privacy = privacy;
            this.VercelProjectId = vercelProjectId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ApiUrl = apiUrl ?? throw new global::System.ArgumentNullException(nameof(apiUrl));
            this.WebUrl = webUrl ?? throw new global::System.ArgumentNullException(nameof(webUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSummary" /> class.
        /// </summary>
        public ProjectSummary()
        {
        }

    }
}