
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsInitRequestVariant1
    {
        /// <summary>
        /// Specifies the initialization method. For this endpoint, it defines the source of content being used to initialize the chat.
        /// </summary>
        /// <default>"files"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "files";

        /// <summary>
        /// An array of inline file objects used to initialize the chat. Each object must contain a file `name` and its `content`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant1" /> class.
        /// </summary>
        /// <param name="files">
        /// An array of inline file objects used to initialize the chat. Each object must contain a file `name` and its `content`.
        /// </param>
        /// <param name="type">
        /// Specifies the initialization method. For this endpoint, it defines the source of content being used to initialize the chat.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsInitRequestVariant1(
            global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>> files,
            string type = "files")
        {
            this.Type = type;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant1" /> class.
        /// </summary>
        public ChatsInitRequestVariant1()
        {
        }

    }
}