
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersDeleteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"mcp_server"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "mcp_server";

        /// <summary>
        /// The ID of the deleted MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Indicates the server was deleted.
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool Deleted { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersDeleteResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted MCP server.
        /// </param>
        /// <param name="object"></param>
        /// <param name="deleted">
        /// Indicates the server was deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersDeleteResponse(
            string id,
            string @object = "mcp_server",
            bool deleted = true)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersDeleteResponse" /> class.
        /// </summary>
        public McpServersDeleteResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="McpServersDeleteResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static McpServersDeleteResponse FromId(string id)
        {
            return new McpServersDeleteResponse
            {
                Id = id,
            };
        }

    }
}