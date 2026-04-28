
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsInitRequestVariant5
    {
        /// <summary>
        /// Specifies the initialization method. For this endpoint, it defines the source of content being used to initialize the chat.
        /// </summary>
        /// <default>"template"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "template";

        /// <summary>
        /// The ID of the template to initialize the chat from. This should be a valid template ID from the v0 template system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant5" /> class.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template to initialize the chat from. This should be a valid template ID from the v0 template system.
        /// </param>
        /// <param name="type">
        /// Specifies the initialization method. For this endpoint, it defines the source of content being used to initialize the chat.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsInitRequestVariant5(
            string templateId,
            string type = "template")
        {
            this.Type = type;
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant5" /> class.
        /// </summary>
        public ChatsInitRequestVariant5()
        {
        }
    }
}