
#nullable enable

namespace V0
{
    /// <summary>
    /// Arbitrary key-value data to attach to the chat. Useful for storing additional data about the chat, such as external user IDs.<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class ChatsCreateRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}