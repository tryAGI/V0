
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsFindLogsResponse
    {
        /// <summary>
        /// Array of log entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.DeploymentsFindLogsResponseLog> Logs { get; set; }

        /// <summary>
        /// Timestamp for pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextSince")]
        public double? NextSince { get; set; }

        /// <summary>
        /// Object type identifier.
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsFindLogsResponse" /> class.
        /// </summary>
        /// <param name="logs">
        /// Array of log entries.
        /// </param>
        /// <param name="nextSince">
        /// Timestamp for pagination.
        /// </param>
        /// <param name="object">
        /// Object type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentsFindLogsResponse(
            global::System.Collections.Generic.IList<global::V0.DeploymentsFindLogsResponseLog> logs,
            double? nextSince,
            string @object = "list")
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.NextSince = nextSince;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsFindLogsResponse" /> class.
        /// </summary>
        public DeploymentsFindLogsResponse()
        {
        }
    }
}