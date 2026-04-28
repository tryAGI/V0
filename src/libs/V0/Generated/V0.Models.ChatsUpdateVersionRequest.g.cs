
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsUpdateVersionRequest
    {
        /// <summary>
        /// Array of files to update with their new content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.ChatsUpdateVersionRequestFile> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsUpdateVersionRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// Array of files to update with their new content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsUpdateVersionRequest(
            global::System.Collections.Generic.IList<global::V0.ChatsUpdateVersionRequestFile> files)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsUpdateVersionRequest" /> class.
        /// </summary>
        public ChatsUpdateVersionRequest()
        {
        }
    }
}