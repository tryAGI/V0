
#nullable enable

namespace V0
{
    /// <summary>
    /// Resolves a Vercel Connect authorization task (a `configure_vercel_connect` agent action with `status: "authorization-required"`). Sign in at the action's `authorizationUrl`, poll GET /chats/{chatId}/connect/status until `ready`, then send this task. Returns 409 while authorization is pending or after it failed, 404 if it has not started or expired.
    /// </summary>
    public sealed partial class ChatsResolveTaskRequestTaskVariant6
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant6TypeJsonConverter))]
        public global::V0.ChatsResolveTaskRequestTaskVariant6Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant6" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsResolveTaskRequestTaskVariant6(
            global::V0.ChatsResolveTaskRequestTaskVariant6Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant6" /> class.
        /// </summary>
        public ChatsResolveTaskRequestTaskVariant6()
        {
        }

    }
}