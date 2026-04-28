
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsUpdateEnvVarsRequest
    {
        /// <summary>
        /// An array of environment variables to update with id and value fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentVariables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateEnvVarsRequest" /> class.
        /// </summary>
        /// <param name="environmentVariables">
        /// An array of environment variables to update with id and value fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsUpdateEnvVarsRequest(
            global::System.Collections.Generic.IList<global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable> environmentVariables)
        {
            this.EnvironmentVariables = environmentVariables ?? throw new global::System.ArgumentNullException(nameof(environmentVariables));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateEnvVarsRequest" /> class.
        /// </summary>
        public ProjectsUpdateEnvVarsRequest()
        {
        }
    }
}