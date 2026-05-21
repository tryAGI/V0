
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsGetEnvVarResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"environment_variable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "environment_variable";

        /// <summary>
        /// Detailed information for an environment variable including its value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.EnvironmentVariableDetailSchema Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsGetEnvVarResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Detailed information for an environment variable including its value.
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsGetEnvVarResponse(
            global::V0.EnvironmentVariableDetailSchema data,
            string @object = "environment_variable")
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsGetEnvVarResponse" /> class.
        /// </summary>
        public ProjectsGetEnvVarResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ProjectsGetEnvVarResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ProjectsGetEnvVarResponse FromData(global::V0.EnvironmentVariableDetailSchema data)
        {
            return new ProjectsGetEnvVarResponse
            {
                Data = data,
            };
        }

    }
}