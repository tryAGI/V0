
#nullable enable

namespace V0
{
    /// <summary>
    /// The configuration used to generate responses in this chat.
    /// </summary>
    public sealed partial class ChatDetailModelConfiguration
    {
        /// <summary>
        /// Model to use for the generation.<br/>
        /// Default Value: v0-pro
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatDetailModelConfigurationModelIdJsonConverter))]
        public global::V0.ChatDetailModelConfigurationModelId? ModelId { get; set; }

        /// <summary>
        /// Enables image generations to generate up to 5 images per version.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageGenerations")]
        public bool? ImageGenerations { get; set; }

        /// <summary>
        /// Enables thinking to generate a response in multiple steps.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public bool? Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDetailModelConfiguration" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Model to use for the generation.<br/>
        /// Default Value: v0-pro
        /// </param>
        /// <param name="imageGenerations">
        /// Enables image generations to generate up to 5 images per version.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="thinking">
        /// Enables thinking to generate a response in multiple steps.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatDetailModelConfiguration(
            global::V0.ChatDetailModelConfigurationModelId? modelId,
            bool? imageGenerations,
            bool? thinking)
        {
            this.ModelId = modelId;
            this.ImageGenerations = imageGenerations;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDetailModelConfiguration" /> class.
        /// </summary>
        public ChatDetailModelConfiguration()
        {
        }
    }
}