
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsInitRequestVariant22
    {
        /// <summary>
        /// Specifies the initialization method. For this endpoint, it defines the source of content being used to initialize the chat.
        /// </summary>
        /// <default>"repo"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "repo";

        /// <summary>
        /// Specifies a repository source for initialization. Supports both public and private GitHub repositories. For private repositories, ensure your GitHub account is connected through Vercel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ChatsInitRequestVariant2Repo Repo { get; set; }

        /// <summary>
        /// Whether to lock all files in the repository to prevent AI from overwriting them during generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockAllFiles")]
        public bool? LockAllFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant22" /> class.
        /// </summary>
        /// <param name="repo">
        /// Specifies a repository source for initialization. Supports both public and private GitHub repositories. For private repositories, ensure your GitHub account is connected through Vercel.
        /// </param>
        /// <param name="lockAllFiles">
        /// Whether to lock all files in the repository to prevent AI from overwriting them during generation
        /// </param>
        /// <param name="type">
        /// Specifies the initialization method. For this endpoint, it defines the source of content being used to initialize the chat.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsInitRequestVariant22(
            global::V0.ChatsInitRequestVariant2Repo repo,
            bool? lockAllFiles,
            string type = "repo")
        {
            this.Type = type;
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.LockAllFiles = lockAllFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant22" /> class.
        /// </summary>
        public ChatsInitRequestVariant22()
        {
        }
    }
}