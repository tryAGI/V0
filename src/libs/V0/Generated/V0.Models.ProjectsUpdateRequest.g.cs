
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsUpdateRequest
    {
        /// <summary>
        /// A new name to assign to the project. Helps with identification and organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A new description to assign to the project. Helps with identification and organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Guidance or goals that provide context for the model when working within the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The privacy setting for the project. For user accounts, this must be "private". For team/enterprise accounts, this can be either "private" or "team".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ProjectsUpdateRequestPrivacyJsonConverter))]
        public global::V0.ProjectsUpdateRequestPrivacy? Privacy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A new name to assign to the project. Helps with identification and organization.
        /// </param>
        /// <param name="description">
        /// A new description to assign to the project. Helps with identification and organization.
        /// </param>
        /// <param name="instructions">
        /// Guidance or goals that provide context for the model when working within the project.
        /// </param>
        /// <param name="privacy">
        /// The privacy setting for the project. For user accounts, this must be "private". For team/enterprise accounts, this can be either "private" or "team".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsUpdateRequest(
            string? name,
            string? description,
            string? instructions,
            global::V0.ProjectsUpdateRequestPrivacy? privacy)
        {
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.Privacy = privacy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateRequest" /> class.
        /// </summary>
        public ProjectsUpdateRequest()
        {
        }
    }
}