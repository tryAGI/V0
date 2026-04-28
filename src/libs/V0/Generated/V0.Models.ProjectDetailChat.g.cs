
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace V0
{
    /// <summary>
    /// Summary of a chat, including metadata like privacy, author, latest version, and URLs.
    /// </summary>
    public sealed partial class ProjectDetailChat
    {
        /// <summary>
        /// A unique identifier for the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fixed value identifying this object as a chat.
        /// </summary>
        /// <default>"chat"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "chat";

        /// <summary>
        /// Indicates whether the chat can be shared via public link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shareable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Shareable { get; set; }

        /// <summary>
        /// Defines the visibility of the chat—private, team-only, or public.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ProjectDetailChatPrivacyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ProjectDetailChatPrivacy Privacy { get; set; }

        /// <summary>
        /// An optional name assigned to the chat by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Deprecated title field preserved for backward compatibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Title { get; set; }

        /// <summary>
        /// The ISO timestamp representing when the chat was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ISO timestamp of the last update to the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Indicates whether the chat is marked as a favorite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favorite")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Favorite { get; set; }

        /// <summary>
        /// The ID of the user who created the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthorId { get; set; }

        /// <summary>
        /// Optional ID of the v0 project associated with this chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Optional ID of the linked Vercel project, if connected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelProjectId")]
        public string? VercelProjectId { get; set; }

        /// <summary>
        /// Web URL to view this chat in the browser.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebUrl { get; set; }

        /// <summary>
        /// API URL to access this chat via the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiUrl { get; set; }

        /// <summary>
        /// The most recent generated version of the chat, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestVersion")]
        public global::V0.ProjectDetailChatLatestVersion? LatestVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDetailChat" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the chat.
        /// </param>
        /// <param name="shareable">
        /// Indicates whether the chat can be shared via public link.
        /// </param>
        /// <param name="privacy">
        /// Defines the visibility of the chat—private, team-only, or public.
        /// </param>
        /// <param name="createdAt">
        /// The ISO timestamp representing when the chat was created.
        /// </param>
        /// <param name="favorite">
        /// Indicates whether the chat is marked as a favorite.
        /// </param>
        /// <param name="authorId">
        /// The ID of the user who created the chat.
        /// </param>
        /// <param name="webUrl">
        /// Web URL to view this chat in the browser.
        /// </param>
        /// <param name="apiUrl">
        /// API URL to access this chat via the API.
        /// </param>
        /// <param name="name">
        /// An optional name assigned to the chat by the user.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO timestamp of the last update to the chat.
        /// </param>
        /// <param name="projectId">
        /// Optional ID of the v0 project associated with this chat.
        /// </param>
        /// <param name="vercelProjectId">
        /// Optional ID of the linked Vercel project, if connected.
        /// </param>
        /// <param name="latestVersion">
        /// The most recent generated version of the chat, if available.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a chat.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectDetailChat(
            string id,
            bool shareable,
            global::V0.ProjectDetailChatPrivacy privacy,
            global::System.DateTime createdAt,
            bool favorite,
            string authorId,
            string webUrl,
            string apiUrl,
            string? name,
            string? updatedAt,
            string? projectId,
            string? vercelProjectId,
            global::V0.ProjectDetailChatLatestVersion? latestVersion,
            string @object = "chat")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Shareable = shareable;
            this.Privacy = privacy;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Favorite = favorite;
            this.AuthorId = authorId ?? throw new global::System.ArgumentNullException(nameof(authorId));
            this.ProjectId = projectId;
            this.VercelProjectId = vercelProjectId;
            this.WebUrl = webUrl ?? throw new global::System.ArgumentNullException(nameof(webUrl));
            this.ApiUrl = apiUrl ?? throw new global::System.ArgumentNullException(nameof(apiUrl));
            this.LatestVersion = latestVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDetailChat" /> class.
        /// </summary>
        public ProjectDetailChat()
        {
        }
    }
}