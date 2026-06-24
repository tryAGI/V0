
#nullable enable

namespace V0
{
    /// <summary>
    /// Resolves a permission request task. The agent wants to execute a tool (shell command, script, MCP call) and needs approval. Also used to resolve environment variable prompts.
    /// </summary>
    public sealed partial class ChatsResolveTaskRequestTaskVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant4TypeJsonConverter))]
        public global::V0.ChatsResolveTaskRequestTaskVariant4Type Type { get; set; }

        /// <summary>
        /// The permissions to grant. Pass the suggestedPermissions from the stopped task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant4Permission> Permissions { get; set; }

        /// <summary>
        /// Optional message from the user about the permission grant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userMessage")]
        public string? UserMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant4" /> class.
        /// </summary>
        /// <param name="permissions">
        /// The permissions to grant. Pass the suggestedPermissions from the stopped task.
        /// </param>
        /// <param name="type"></param>
        /// <param name="userMessage">
        /// Optional message from the user about the permission grant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsResolveTaskRequestTaskVariant4(
            global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant4Permission> permissions,
            global::V0.ChatsResolveTaskRequestTaskVariant4Type type,
            string? userMessage)
        {
            this.Type = type;
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.UserMessage = userMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant4" /> class.
        /// </summary>
        public ChatsResolveTaskRequestTaskVariant4()
        {
        }

    }
}