
#nullable enable

namespace V0
{
    /// <summary>
    /// Resolves a question task. The agent asked the user one or more multiple-choice questions.
    /// </summary>
    public sealed partial class ChatsResolveTaskRequestTaskVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"answered-questions"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "answered-questions";

        /// <summary>
        /// Answers to the questions the agent asked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant3Answer> Answers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant3" /> class.
        /// </summary>
        /// <param name="answers">
        /// Answers to the questions the agent asked.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsResolveTaskRequestTaskVariant3(
            global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant3Answer> answers,
            string type = "answered-questions")
        {
            this.Type = type;
            this.Answers = answers ?? throw new global::System.ArgumentNullException(nameof(answers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant3" /> class.
        /// </summary>
        public ChatsResolveTaskRequestTaskVariant3()
        {
        }
    }
}