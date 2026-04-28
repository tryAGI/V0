
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace V0
{
    /// <summary>
    /// Overrides for the model behavior.
    /// </summary>
    public sealed partial class ChatsResolveTaskRequestModelConfiguration
    {
        /// <summary>
        /// Deprecated Model ID field preserved for backward compatibility.<br/>
        /// Default Value: v0-pro
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsResolveTaskRequestModelConfigurationModelIdJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::V0.ChatsResolveTaskRequestModelConfigurationModelId? ModelId { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestModelConfiguration" /> class.
        /// </summary>
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
        public ChatsResolveTaskRequestModelConfiguration(
            bool? imageGenerations,
            bool? thinking)
        {
            this.ImageGenerations = imageGenerations;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestModelConfiguration" /> class.
        /// </summary>
        public ChatsResolveTaskRequestModelConfiguration()
        {
        }
    }
}