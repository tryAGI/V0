
#nullable enable

namespace V0
{
    /// <summary>
    /// Resolves a plan review task. The agent proposed an implementation plan and is waiting for approval.
    /// </summary>
    public sealed partial class ChatsResolveTaskRequestTaskVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"plan-exit-response"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "plan-exit-response";

        /// <summary>
        /// Whether the plan is approved, rejected, or needs changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant2StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ChatsResolveTaskRequestTaskVariant2Status Status { get; set; }

        /// <summary>
        /// Feedback or instructions for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant2" /> class.
        /// </summary>
        /// <param name="status">
        /// Whether the plan is approved, rejected, or needs changes.
        /// </param>
        /// <param name="content">
        /// Feedback or instructions for the agent.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsResolveTaskRequestTaskVariant2(
            global::V0.ChatsResolveTaskRequestTaskVariant2Status status,
            string content,
            string type = "plan-exit-response")
        {
            this.Type = type;
            this.Status = status;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant2" /> class.
        /// </summary>
        public ChatsResolveTaskRequestTaskVariant2()
        {
        }

    }
}