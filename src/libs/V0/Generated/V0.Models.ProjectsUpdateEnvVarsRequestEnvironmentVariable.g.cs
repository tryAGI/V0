
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsUpdateEnvVarsRequestEnvironmentVariable
    {
        /// <summary>
        /// The unique identifier of the environment variable to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The new value of the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateEnvVarsRequestEnvironmentVariable" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the environment variable to update.
        /// </param>
        /// <param name="value">
        /// The new value of the environment variable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsUpdateEnvVarsRequestEnvironmentVariable(
            string id,
            string value)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateEnvVarsRequestEnvironmentVariable" /> class.
        /// </summary>
        public ProjectsUpdateEnvVarsRequestEnvironmentVariable()
        {
        }
    }
}