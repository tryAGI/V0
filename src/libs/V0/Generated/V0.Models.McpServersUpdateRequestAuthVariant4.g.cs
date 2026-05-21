
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersUpdateRequestAuthVariant4
    {
        /// <summary>
        /// OAuth 2.1 authentication.
        /// </summary>
        /// <default>"oauth"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "oauth";

        /// <summary>
        /// OAuth configuration for the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.McpServersUpdateRequestAuthVariant4Config Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersUpdateRequestAuthVariant4" /> class.
        /// </summary>
        /// <param name="config">
        /// OAuth configuration for the MCP server.
        /// </param>
        /// <param name="type">
        /// OAuth 2.1 authentication.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersUpdateRequestAuthVariant4(
            global::V0.McpServersUpdateRequestAuthVariant4Config config,
            string type = "oauth")
        {
            this.Type = type;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersUpdateRequestAuthVariant4" /> class.
        /// </summary>
        public McpServersUpdateRequestAuthVariant4()
        {
        }

        /// <summary>
        /// Creates a new <see cref="McpServersUpdateRequestAuthVariant4"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static McpServersUpdateRequestAuthVariant4 FromConfig(global::V0.McpServersUpdateRequestAuthVariant4Config config)
        {
            return new McpServersUpdateRequestAuthVariant4
            {
                Config = config,
            };
        }

    }
}