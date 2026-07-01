
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsSendMessageRequestSkillVariant1
    {
        /// <summary>
        /// Discriminator: a skills.sh skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsSendMessageRequestSkillVariant1TypeJsonConverter))]
        public global::V0.ChatsSendMessageRequestSkillVariant1Type Type { get; set; }

        /// <summary>
        /// Skill ID from skills.sh.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsSendMessageRequestSkillVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// Skill ID from skills.sh.
        /// </param>
        /// <param name="type">
        /// Discriminator: a skills.sh skill.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsSendMessageRequestSkillVariant1(
            string id,
            global::V0.ChatsSendMessageRequestSkillVariant1Type type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsSendMessageRequestSkillVariant1" /> class.
        /// </summary>
        public ChatsSendMessageRequestSkillVariant1()
        {
        }

    }
}