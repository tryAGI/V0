
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServersUpdateRequestAuthVariant1
    {
        /// <summary>
        /// No authentication required.
        /// </summary>
        /// <default>"none"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "none";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersUpdateRequestAuthVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// No authentication required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServersUpdateRequestAuthVariant1(
            string type = "none")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServersUpdateRequestAuthVariant1" /> class.
        /// </summary>
        public McpServersUpdateRequestAuthVariant1()
        {
        }

    }
}