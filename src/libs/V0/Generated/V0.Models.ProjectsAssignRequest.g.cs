
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsAssignRequest
    {
        /// <summary>
        /// The ID of the chat to assign the project to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChatId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAssignRequest" /> class.
        /// </summary>
        /// <param name="chatId">
        /// The ID of the chat to assign the project to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsAssignRequest(
            string chatId)
        {
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAssignRequest" /> class.
        /// </summary>
        public ProjectsAssignRequest()
        {
        }
    }
}