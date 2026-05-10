
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatDetailPermissions
    {
        /// <summary>
        /// If true, the user has write access to the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Write { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDetailPermissions" /> class.
        /// </summary>
        /// <param name="write">
        /// If true, the user has write access to the chat.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatDetailPermissions(
            bool write)
        {
            this.Write = write;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDetailPermissions" /> class.
        /// </summary>
        public ChatDetailPermissions()
        {
        }

    }
}