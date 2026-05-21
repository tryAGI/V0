
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsDeleteResponse
    {
        /// <summary>
        /// The unique identifier of the deleted project.
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
        /// Confirmation that the project has been deleted.
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool Deleted { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsDeleteResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the deleted project.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a project.
        /// </param>
        /// <param name="deleted">
        /// Confirmation that the project has been deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsDeleteResponse(
            string id,
            string @object = "project",
            bool deleted = true)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsDeleteResponse" /> class.
        /// </summary>
        public ProjectsDeleteResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ProjectsDeleteResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ProjectsDeleteResponse FromId(string id)
        {
            return new ProjectsDeleteResponse
            {
                Id = id,
            };
        }

    }
}