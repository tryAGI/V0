
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsInitRequestVariant3
    {
        /// <summary>
        /// Specifies the initialization method. For this endpoint, it defines the source of content being used to initialize the chat.
        /// </summary>
        /// <default>"registry"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "registry";

        /// <summary>
        /// Allows initialization from a predefined component or code registry. Includes the registry source and identifier for the desired component/module.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ChatsInitRequestVariant3Registry Registry { get; set; }

        /// <summary>
        /// Whether to lock all files from the registry to prevent AI from overwriting them during generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockAllFiles")]
        public bool? LockAllFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant3" /> class.
        /// </summary>
        /// <param name="registry">
        /// Allows initialization from a predefined component or code registry. Includes the registry source and identifier for the desired component/module.
        /// </param>
        /// <param name="lockAllFiles">
        /// Whether to lock all files from the registry to prevent AI from overwriting them during generation
        /// </param>
        /// <param name="type">
        /// Specifies the initialization method. For this endpoint, it defines the source of content being used to initialize the chat.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsInitRequestVariant3(
            global::V0.ChatsInitRequestVariant3Registry registry,
            bool? lockAllFiles,
            string type = "registry")
        {
            this.Type = type;
            this.Registry = registry ?? throw new global::System.ArgumentNullException(nameof(registry));
            this.LockAllFiles = lockAllFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant3" /> class.
        /// </summary>
        public ChatsInitRequestVariant3()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatsInitRequestVariant3"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatsInitRequestVariant3 FromRegistry(global::V0.ChatsInitRequestVariant3Registry registry)
        {
            return new ChatsInitRequestVariant3
            {
                Registry = registry,
            };
        }

    }
}