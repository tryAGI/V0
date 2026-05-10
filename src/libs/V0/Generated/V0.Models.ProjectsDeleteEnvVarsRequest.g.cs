
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsDeleteEnvVarsRequest
    {
        /// <summary>
        /// An array of environment variable IDs to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentVariableIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EnvironmentVariableIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsDeleteEnvVarsRequest" /> class.
        /// </summary>
        /// <param name="environmentVariableIds">
        /// An array of environment variable IDs to delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsDeleteEnvVarsRequest(
            global::System.Collections.Generic.IList<string> environmentVariableIds)
        {
            this.EnvironmentVariableIds = environmentVariableIds ?? throw new global::System.ArgumentNullException(nameof(environmentVariableIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsDeleteEnvVarsRequest" /> class.
        /// </summary>
        public ProjectsDeleteEnvVarsRequest()
        {
        }

    }
}