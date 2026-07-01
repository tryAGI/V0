
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsCreateRequestSkillVariant2
    {
        /// <summary>
        /// Discriminator: a user- or team-scoped memory skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsCreateRequestSkillVariant2TypeJsonConverter))]
        public global::V0.ChatsCreateRequestSkillVariant2Type Type { get; set; }

        /// <summary>
        /// Whether the skill lives in user or team memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsCreateRequestSkillVariant2ScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ChatsCreateRequestSkillVariant2Scope Scope { get; set; }

        /// <summary>
        /// Name of the memory skill to attach.
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
        /// Initializes a new instance of the <see cref="ChatsCreateRequestSkillVariant2" /> class.
        /// </summary>
        /// <param name="scope">
        /// Whether the skill lives in user or team memory.
        /// </param>
        /// <param name="skillName">
        /// Name of the memory skill to attach.
        /// </param>
        /// <param name="type">
        /// Discriminator: a user- or team-scoped memory skill.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsCreateRequestSkillVariant2(
            global::V0.ChatsCreateRequestSkillVariant2Scope scope,
            string skillName,
            global::V0.ChatsCreateRequestSkillVariant2Type type)
        {
            this.Type = type;
            this.Scope = scope;
            this.SkillName = skillName ?? throw new global::System.ArgumentNullException(nameof(skillName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsCreateRequestSkillVariant2" /> class.
        /// </summary>
        public ChatsCreateRequestSkillVariant2()
        {
        }

    }
}