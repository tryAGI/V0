
#nullable enable

namespace V0
{
    /// <summary>
    /// Resolves a Vercel Connect setup task. The agent asked the user to complete connector setup in a browser (a `configure_vercel_connect` agent action with `status: "setup-required"`). Complete setup at the action’s `setupUrl`, poll GET /chats/{chatId}/connect/status until it returns `ready`, then send this task. The server verifies the setup result and attaches the connector; no connector ID is needed. Returns 409 if setup is still pending or failed, or 404 if setup has not started or the request expired.
    /// </summary>
    public sealed partial class ChatsResolveTaskRequestTaskVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant5TypeJsonConverter))]
        public global::V0.ChatsResolveTaskRequestTaskVariant5Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant5" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsResolveTaskRequestTaskVariant5(
            global::V0.ChatsResolveTaskRequestTaskVariant5Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant5" /> class.
        /// </summary>
        public ChatsResolveTaskRequestTaskVariant5()
        {
        }

    }
}