
#nullable enable

namespace V0
{
    /// <summary>
    /// Specifies a repository source for initialization. Supports both public and private GitHub repositories. For private repositories, ensure your GitHub account is connected through Vercel.
    /// </summary>
    public sealed partial class ChatsInitRequestVariant2Repo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant2Repo" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="branch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsInitRequestVariant2Repo(
            string url,
            string? branch)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Branch = branch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant2Repo" /> class.
        /// </summary>
        public ChatsInitRequestVariant2Repo()
        {
        }

    }
}