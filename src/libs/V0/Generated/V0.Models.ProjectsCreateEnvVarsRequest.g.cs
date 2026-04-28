
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsCreateEnvVarsRequest
    {
        /// <summary>
        /// An array of environment variables to create with key and value fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentVariables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// Whether to overwrite existing environment variables with the same keys. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upsert")]
        public bool? Upsert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateEnvVarsRequest" /> class.
        /// </summary>
        /// <param name="environmentVariables">
        /// An array of environment variables to create with key and value fields.
        /// </param>
        /// <param name="upsert">
        /// Whether to overwrite existing environment variables with the same keys. Defaults to false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsCreateEnvVarsRequest(
            global::System.Collections.Generic.IList<global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable> environmentVariables,
            bool? upsert)
        {
            this.EnvironmentVariables = environmentVariables ?? throw new global::System.ArgumentNullException(nameof(environmentVariables));
            this.Upsert = upsert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateEnvVarsRequest" /> class.
        /// </summary>
        public ProjectsCreateEnvVarsRequest()
        {
        }
    }
}