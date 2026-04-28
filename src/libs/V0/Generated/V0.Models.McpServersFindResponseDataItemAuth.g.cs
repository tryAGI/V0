
#nullable enable

namespace V0
{
    /// <summary>
    /// Authentication type for the MCP server. Sensitive values like tokens and headers are not returned.
    /// </summary>
    public sealed partial class McpServersFindResponseDataItemAuth
    {
        /// <summary>
        /// The type of authentication configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.McpServersFindResponseDataItemAuthTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.McpServersFindResponseDataItemAuthType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersFindResponseDataItemAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of authentication configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersFindResponseDataItemAuth(
            global::V0.McpServersFindResponseDataItemAuthType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersFindResponseDataItemAuth" /> class.
        /// </summary>
        public McpServersFindResponseDataItemAuth()
        {
        }
    }
}