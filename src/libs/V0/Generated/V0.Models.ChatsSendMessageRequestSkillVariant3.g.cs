
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsSendMessageRequestSkillVariant3
    {
        /// <summary>
        /// Discriminator: a skill defined in the project repo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsSendMessageRequestSkillVariant3TypeJsonConverter))]
        public global::V0.ChatsSendMessageRequestSkillVariant3Type Type { get; set; }

        /// <summary>
        /// Name of the project skill to attach.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skillName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsSendMessageRequestSkillVariant3" /> class.
        /// </summary>
        /// <param name="skillName">
        /// Name of the project skill to attach.
        /// </param>
        /// <param name="type">
        /// Discriminator: a skill defined in the project repo.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsSendMessageRequestSkillVariant3(
            string skillName,
            global::V0.ChatsSendMessageRequestSkillVariant3Type type)
        {
            this.Type = type;
            this.SkillName = skillName ?? throw new global::System.ArgumentNullException(nameof(skillName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsSendMessageRequestSkillVariant3" /> class.
        /// </summary>
        public ChatsSendMessageRequestSkillVariant3()
        {
        }

    }
}