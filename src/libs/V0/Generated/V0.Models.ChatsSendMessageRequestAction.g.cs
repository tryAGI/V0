
#nullable enable

namespace V0
{
    /// <summary>
    /// An optional action to perform. Use `fix-with-v0` to trigger automatic error fixing — the message should contain the error logs or context to fix.
    /// </summary>
    public sealed partial class ChatsSendMessageRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"fix-with-v0"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "fix-with-v0";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsSendMessageRequestAction" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsSendMessageRequestAction(
            string type = "fix-with-v0")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsSendMessageRequestAction" /> class.
        /// </summary>
        public ChatsSendMessageRequestAction()
        {
        }
    }
}