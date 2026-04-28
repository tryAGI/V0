
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsResolveTaskRequestTaskVariant3Answer
    {
        /// <summary>
        /// The ID of the question being answered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QuestionId { get; set; }

        /// <summary>
        /// The text of the question being answered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questionText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QuestionText { get; set; }

        /// <summary>
        /// The labels of the selected options. For single-select questions, pass one item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedLabels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SelectedLabels { get; set; }

        /// <summary>
        /// Free-form text input, used when the user selects "Other" or wants to add context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customText")]
        public string? CustomText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant3Answer" /> class.
        /// </summary>
        /// <param name="questionId">
        /// The ID of the question being answered.
        /// </param>
        /// <param name="questionText">
        /// The text of the question being answered.
        /// </param>
        /// <param name="selectedLabels">
        /// The labels of the selected options. For single-select questions, pass one item.
        /// </param>
        /// <param name="customText">
        /// Free-form text input, used when the user selects "Other" or wants to add context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsResolveTaskRequestTaskVariant3Answer(
            string questionId,
            string questionText,
            global::System.Collections.Generic.IList<string> selectedLabels,
            string? customText)
        {
            this.QuestionId = questionId ?? throw new global::System.ArgumentNullException(nameof(questionId));
            this.QuestionText = questionText ?? throw new global::System.ArgumentNullException(nameof(questionText));
            this.SelectedLabels = selectedLabels ?? throw new global::System.ArgumentNullException(nameof(selectedLabels));
            this.CustomText = customText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant3Answer" /> class.
        /// </summary>
        public ChatsResolveTaskRequestTaskVariant3Answer()
        {
        }
    }
}