
#nullable enable

namespace V0
{
    /// <summary>
    /// Basic metadata about a Vercel project connected to a v0 project.
    /// </summary>
    public sealed partial class VercelProjectSummary
    {
        /// <summary>
        /// A unique identifier for the linked Vercel project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fixed value identifying this object as a Vercel project.
        /// </summary>
        /// <default>"vercel_project"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "vercel_project";

        /// <summary>
        /// The name of the Vercel project.
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
        /// Initializes a new instance of the <see cref="VercelProjectSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the linked Vercel project.
        /// </param>
        /// <param name="name">
        /// The name of the Vercel project.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a Vercel project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VercelProjectSummary(
            string id,
            string name,
            string @object = "vercel_project")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VercelProjectSummary" /> class.
        /// </summary>
        public VercelProjectSummary()
        {
        }

    }
}