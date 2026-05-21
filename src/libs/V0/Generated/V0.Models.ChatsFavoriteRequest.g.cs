
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsFavoriteRequest
    {
        /// <summary>
        /// Specifies whether the chat should be marked as a favorite.<br/>
        /// - `"true"`: mark as favorite<br/>
        /// - `"false"`: remove from favorites
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFavorite")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFavorite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsFavoriteRequest" /> class.
        /// </summary>
        /// <param name="isFavorite">
        /// Specifies whether the chat should be marked as a favorite.<br/>
        /// - `"true"`: mark as favorite<br/>
        /// - `"false"`: remove from favorites
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsFavoriteRequest(
            bool isFavorite)
        {
            this.IsFavorite = isFavorite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsFavoriteRequest" /> class.
        /// </summary>
        public ChatsFavoriteRequest()
        {
        }

    }
}