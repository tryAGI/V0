
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportsGetUserActivityResponseDataItem
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
        /// <default>"user_activity"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "user_activity";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.ReportsGetUserActivityResponseDataItemUser User { get; set; }

        /// <summary>
        /// Total number of chats created by the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ChatCount { get; set; }

        /// <summary>
        /// Total number of messages sent by the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MessageCount { get; set; }

        /// <summary>
        /// Number of distinct days the user was active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeDays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActiveDays { get; set; }

        /// <summary>
        /// Timestamp of the user's first activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstActivity")]
        public global::System.DateTime? FirstActivity { get; set; }

        /// <summary>
        /// Timestamp of the user's last activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastActivity")]
        public global::System.DateTime? LastActivity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUserActivityResponseDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <param name="chatCount">
        /// Total number of chats created by the user
        /// </param>
        /// <param name="messageCount">
        /// Total number of messages sent by the user
        /// </param>
        /// <param name="activeDays">
        /// Number of distinct days the user was active
        /// </param>
        /// <param name="firstActivity">
        /// Timestamp of the user's first activity
        /// </param>
        /// <param name="lastActivity">
        /// Timestamp of the user's last activity
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportsGetUserActivityResponseDataItem(
            string id,
            global::V0.ReportsGetUserActivityResponseDataItemUser user,
            double chatCount,
            double messageCount,
            double activeDays,
            global::System.DateTime? firstActivity,
            global::System.DateTime? lastActivity,
            string @object = "user_activity")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.ChatCount = chatCount;
            this.MessageCount = messageCount;
            this.ActiveDays = activeDays;
            this.FirstActivity = firstActivity;
            this.LastActivity = lastActivity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUserActivityResponseDataItem" /> class.
        /// </summary>
        public ReportsGetUserActivityResponseDataItem()
        {
        }
    }
}