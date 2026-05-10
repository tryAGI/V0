
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsForkRequest
    {
        /// <summary>
        /// The identifier of the specific chat version to fork from. If omitted, the latest version will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Determines the privacy setting of the forked chat. This can control whether the chat is visible only to the user, to team members, or is public.<br/>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsForkRequestPrivacyJsonConverter))]
        public global::V0.ChatsForkRequestPrivacy? Privacy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsForkRequest" /> class.
        /// </summary>
        /// <param name="versionId">
        /// The identifier of the specific chat version to fork from. If omitted, the latest version will be used.
        /// </param>
        /// <param name="privacy">
        /// Determines the privacy setting of the forked chat. This can control whether the chat is visible only to the user, to team members, or is public.<br/>
        /// Default Value: private
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsForkRequest(
            string? versionId,
            global::V0.ChatsForkRequestPrivacy? privacy)
        {
            this.VersionId = versionId;
            this.Privacy = privacy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsForkRequest" /> class.
        /// </summary>
        public ChatsForkRequest()
        {
        }

    }
}