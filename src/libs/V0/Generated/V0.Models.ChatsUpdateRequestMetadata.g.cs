
#nullable enable

namespace V0
{
    /// <summary>
    /// Arbitrary key-value data to attach to the chat. Useful for storing additional data about the chat, such as external user IDs. Metadata added will be merged with existing attributes. Pass `null` as the value to delete a specific key, or pass `null` instead of an object to delete all existing metadata.
    /// </summary>
    public sealed partial class ChatsUpdateRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}