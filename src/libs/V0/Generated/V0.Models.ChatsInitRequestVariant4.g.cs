
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsInitRequestVariant4
    {
        /// <summary>
        /// Specifies the initialization method. For this endpoint, it defines the source of content being used to initialize the chat.
        /// </summary>
        /// <default>"zip"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "zip";

        /// <summary>
        /// Provides a zipped bundle of files as the input source. Typically includes a base64-encoded archive or a remote URL reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ChatsInitRequestVariant4Zip Zip { get; set; }

        /// <summary>
        /// Whether to lock all files from the zip archive to prevent AI from overwriting them during generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockAllFiles")]
        public bool? LockAllFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant4" /> class.
        /// </summary>
        /// <param name="zip">
        /// Provides a zipped bundle of files as the input source. Typically includes a base64-encoded archive or a remote URL reference.
        /// </param>
        /// <param name="lockAllFiles">
        /// Whether to lock all files from the zip archive to prevent AI from overwriting them during generation
        /// </param>
        /// <param name="type">
        /// Specifies the initialization method. For this endpoint, it defines the source of content being used to initialize the chat.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsInitRequestVariant4(
            global::V0.ChatsInitRequestVariant4Zip zip,
            bool? lockAllFiles,
            string type = "zip")
        {
            this.Type = type;
            this.Zip = zip ?? throw new global::System.ArgumentNullException(nameof(zip));
            this.LockAllFiles = lockAllFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant4" /> class.
        /// </summary>
        public ChatsInitRequestVariant4()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatsInitRequestVariant4"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatsInitRequestVariant4 FromZip(global::V0.ChatsInitRequestVariant4Zip zip)
        {
            return new ChatsInitRequestVariant4
            {
                Zip = zip,
            };
        }

    }
}