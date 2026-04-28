
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersCreateRequestAuthVariant3
    {
        /// <summary>
        /// Custom headers authentication.
        /// </summary>
        /// <default>"custom-headers"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom-headers";

        /// <summary>
        /// Key-value pairs of custom headers to include in requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersCreateRequestAuthVariant3" /> class.
        /// </summary>
        /// <param name="headers">
        /// Key-value pairs of custom headers to include in requests.
        /// </param>
        /// <param name="type">
        /// Custom headers authentication.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersCreateRequestAuthVariant3(
            global::System.Collections.Generic.Dictionary<string, string> headers,
            string type = "custom-headers")
        {
            this.Type = type;
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersCreateRequestAuthVariant3" /> class.
        /// </summary>
        public McpServersCreateRequestAuthVariant3()
        {
        }
    }
}