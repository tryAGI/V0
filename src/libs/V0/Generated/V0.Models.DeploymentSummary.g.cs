
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentSummary
    {
        /// <summary>
        /// A unique identifier for the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fixed value identifying this object as a deployment.
        /// </summary>
        /// <default>"deployment"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "deployment";

        /// <summary>
        /// URL to the deployment inspector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inspectorUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InspectorUrl { get; set; }

        /// <summary>
        /// The ID of the chat that this deployment is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChatId { get; set; }

        /// <summary>
        /// The ID of the project that this deployment is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The ID of the version that this deployment is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// The API endpoint URL for accessing this deployment programmatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiUrl { get; set; }

        /// <summary>
        /// The web URL where the deployment can be viewed or managed.
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
        /// Initializes a new instance of the <see cref="DeploymentSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the deployment.
        /// </param>
        /// <param name="inspectorUrl">
        /// URL to the deployment inspector.
        /// </param>
        /// <param name="chatId">
        /// The ID of the chat that this deployment is scoped to.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project that this deployment is scoped to.
        /// </param>
        /// <param name="versionId">
        /// The ID of the version that this deployment is scoped to.
        /// </param>
        /// <param name="apiUrl">
        /// The API endpoint URL for accessing this deployment programmatically.
        /// </param>
        /// <param name="webUrl">
        /// The web URL where the deployment can be viewed or managed.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentSummary(
            string id,
            string inspectorUrl,
            string chatId,
            string projectId,
            string versionId,
            string apiUrl,
            string webUrl,
            string @object = "deployment")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.InspectorUrl = inspectorUrl ?? throw new global::System.ArgumentNullException(nameof(inspectorUrl));
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.ApiUrl = apiUrl ?? throw new global::System.ArgumentNullException(nameof(apiUrl));
            this.WebUrl = webUrl ?? throw new global::System.ArgumentNullException(nameof(webUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentSummary" /> class.
        /// </summary>
        public DeploymentSummary()
        {
        }
    }
}