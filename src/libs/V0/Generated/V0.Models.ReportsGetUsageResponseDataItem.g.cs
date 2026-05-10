
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportsGetUsageResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"usage_event"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "usage_event";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ReportsGetUsageResponseDataItemTypeJsonConverter))]
        public global::V0.ReportsGetUsageResponseDataItemType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptCost")]
        public string? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionCost")]
        public string? CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatId")]
        public string? ChatId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        public string? MessageId { get; set; }

        /// <summary>
        /// Deprecated - use user object instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Details of the authenticated user, including profile and contact information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::V0.UserSummarySchema? User { get; set; }

        /// <summary>
        /// The ISO timestamp representing when the usage event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUsageResponseDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="totalCost"></param>
        /// <param name="createdAt">
        /// The ISO timestamp representing when the usage event was created.
        /// </param>
        /// <param name="type"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="userId">
        /// Deprecated - use user object instead
        /// </param>
        /// <param name="user">
        /// Details of the authenticated user, including profile and contact information.
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportsGetUsageResponseDataItem(
            string id,
            string totalCost,
            global::System.DateTime createdAt,
            global::V0.ReportsGetUsageResponseDataItemType? type,
            string? promptCost,
            string? completionCost,
            string? chatId,
            string? messageId,
            string? userId,
            global::V0.UserSummarySchema? user,
            string @object = "usage_event")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Type = type;
            this.PromptCost = promptCost;
            this.CompletionCost = completionCost;
            this.TotalCost = totalCost ?? throw new global::System.ArgumentNullException(nameof(totalCost));
            this.ChatId = chatId;
            this.MessageId = messageId;
            this.UserId = userId;
            this.User = user;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUsageResponseDataItem" /> class.
        /// </summary>
        public ReportsGetUsageResponseDataItem()
        {
        }

    }
}