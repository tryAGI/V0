
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsVercelProjectsCreateRequest
    {
        /// <summary>
        /// The ID of the v0 project to link to the new Vercel project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The name to assign to the new Vercel project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsVercelProjectsCreateRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the v0 project to link to the new Vercel project.
        /// </param>
        /// <param name="name">
        /// The name to assign to the new Vercel project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsVercelProjectsCreateRequest(
            string projectId,
            string name)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsVercelProjectsCreateRequest" /> class.
        /// </summary>
        public IntegrationsVercelProjectsCreateRequest()
        {
        }
    }
}