
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsDeleteVersionFilesRequest
    {
        /// <summary>
        /// Array of file paths to delete (e.g., ["components/test.tsx", "lib/utils.ts"])
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filePaths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FilePaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsDeleteVersionFilesRequest" /> class.
        /// </summary>
        /// <param name="filePaths">
        /// Array of file paths to delete (e.g., ["components/test.tsx", "lib/utils.ts"])
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsDeleteVersionFilesRequest(
            global::System.Collections.Generic.IList<string> filePaths)
        {
            this.FilePaths = filePaths ?? throw new global::System.ArgumentNullException(nameof(filePaths));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsDeleteVersionFilesRequest" /> class.
        /// </summary>
        public ChatsDeleteVersionFilesRequest()
        {
        }
    }
}