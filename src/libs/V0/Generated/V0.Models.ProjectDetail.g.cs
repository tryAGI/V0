
#nullable enable

namespace V0
{
    /// <summary>
    /// Full representation of a project, including its associated chats.
    /// </summary>
    public sealed partial class ProjectDetail
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ProjectDetailPrivacyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ProjectDetailPrivacy Privacy { get; set; }

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
        /// The description of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The instructions for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// List of all chats that are associated with this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.ProjectDetailChat> Chats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDetail" /> class.
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
        /// <param name="chats">
        /// List of all chats that are associated with this project.
        /// </param>
        /// <param name="vercelProjectId">
        /// Optional ID of the linked Vercel project, if connected.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO timestamp of the most recent update, if available.
        /// </param>
        /// <param name="description">
        /// The description of the project.
        /// </param>
        /// <param name="instructions">
        /// The instructions for the project.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectDetail(
            string id,
            string name,
            global::V0.ProjectDetailPrivacy privacy,
            global::System.DateTime createdAt,
            string apiUrl,
            string webUrl,
            global::System.Collections.Generic.IList<global::V0.ProjectDetailChat> chats,
            string? vercelProjectId,
            global::System.DateTime? updatedAt,
            string? description,
            string? instructions,
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
            this.Description = description;
            this.Instructions = instructions;
            this.Chats = chats ?? throw new global::System.ArgumentNullException(nameof(chats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDetail" /> class.
        /// </summary>
        public ProjectDetail()
        {
        }
    }
}