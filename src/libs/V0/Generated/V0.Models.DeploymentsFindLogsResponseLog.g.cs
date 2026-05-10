
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsFindLogsResponseLog
    {
        /// <summary>
        /// Log creation timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Deployment ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Log entry ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Log message content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Output stream type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.DeploymentsFindLogsResponseLogTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.DeploymentsFindLogsResponseLogType Type { get; set; }

        /// <summary>
        /// Log severity level.<br/>
        /// Default Value: info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.DeploymentsFindLogsResponseLogLevelJsonConverter))]
        public global::V0.DeploymentsFindLogsResponseLogLevel? Level { get; set; }

        /// <summary>
        /// Object type identifier.
        /// </summary>
        /// <default>"deployment_log"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "deployment_log";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsFindLogsResponseLog" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Log creation timestamp.
        /// </param>
        /// <param name="deploymentId">
        /// Deployment ID.
        /// </param>
        /// <param name="id">
        /// Log entry ID.
        /// </param>
        /// <param name="text">
        /// Log message content.
        /// </param>
        /// <param name="type">
        /// Output stream type.
        /// </param>
        /// <param name="level">
        /// Log severity level.<br/>
        /// Default Value: info
        /// </param>
        /// <param name="object">
        /// Object type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentsFindLogsResponseLog(
            string createdAt,
            string deploymentId,
            string id,
            string text,
            global::V0.DeploymentsFindLogsResponseLogType type,
            global::V0.DeploymentsFindLogsResponseLogLevel? level,
            string @object = "deployment_log")
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
            this.Level = level;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsFindLogsResponseLog" /> class.
        /// </summary>
        public DeploymentsFindLogsResponseLog()
        {
        }

    }
}