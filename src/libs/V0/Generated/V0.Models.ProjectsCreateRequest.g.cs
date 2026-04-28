
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsCreateRequest
    {
        /// <summary>
        /// The name of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A brief summary of the project’s purpose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An icon identifier to visually represent the project.<br/>
        /// Default Value: icon-wand-sparkles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// A list of key-value pairs used to define runtime variables for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentVariables")]
        public global::System.Collections.Generic.IList<global::V0.ProjectsCreateRequestEnvironmentVariable>? EnvironmentVariables { get; set; }

        /// <summary>
        /// Guidance or goals that provide context for the model when working within the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The ID of an existing Vercel project to link to. If not provided, a new Vercel project will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelProjectId")]
        public string? VercelProjectId { get; set; }

        /// <summary>
        /// The privacy setting for the project. For user accounts, this is always "private". For team/enterprise accounts, this can be either "private" or "team".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ProjectsCreateRequestPrivacyJsonConverter))]
        public global::V0.ProjectsCreateRequestPrivacy? Privacy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the project.
        /// </param>
        /// <param name="description">
        /// A brief summary of the project’s purpose.
        /// </param>
        /// <param name="icon">
        /// An icon identifier to visually represent the project.<br/>
        /// Default Value: icon-wand-sparkles
        /// </param>
        /// <param name="environmentVariables">
        /// A list of key-value pairs used to define runtime variables for the project.
        /// </param>
        /// <param name="instructions">
        /// Guidance or goals that provide context for the model when working within the project.
        /// </param>
        /// <param name="vercelProjectId">
        /// The ID of an existing Vercel project to link to. If not provided, a new Vercel project will be created.
        /// </param>
        /// <param name="privacy">
        /// The privacy setting for the project. For user accounts, this is always "private". For team/enterprise accounts, this can be either "private" or "team".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsCreateRequest(
            string name,
            string? description,
            string? icon,
            global::System.Collections.Generic.IList<global::V0.ProjectsCreateRequestEnvironmentVariable>? environmentVariables,
            string? instructions,
            string? vercelProjectId,
            global::V0.ProjectsCreateRequestPrivacy? privacy)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Icon = icon;
            this.EnvironmentVariables = environmentVariables;
            this.Instructions = instructions;
            this.VercelProjectId = vercelProjectId;
            this.Privacy = privacy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateRequest" /> class.
        /// </summary>
        public ProjectsCreateRequest()
        {
        }
    }
}