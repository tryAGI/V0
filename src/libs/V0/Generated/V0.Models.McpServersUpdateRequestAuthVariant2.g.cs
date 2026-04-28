
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersUpdateRequestAuthVariant2
    {
        /// <summary>
        /// Bearer token authentication.
        /// </summary>
        /// <default>"bearer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "bearer";

        /// <summary>
        /// The bearer token for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersUpdateRequestAuthVariant2" /> class.
        /// </summary>
        /// <param name="token">
        /// The bearer token for authentication.
        /// </param>
        /// <param name="type">
        /// Bearer token authentication.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersUpdateRequestAuthVariant2(
            string token,
            string type = "bearer")
        {
            this.Type = type;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersUpdateRequestAuthVariant2" /> class.
        /// </summary>
        public McpServersUpdateRequestAuthVariant2()
        {
        }
    }
}