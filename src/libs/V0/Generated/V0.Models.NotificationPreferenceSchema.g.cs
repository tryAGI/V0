
#nullable enable

namespace V0
{
    /// <summary>
    /// User preference for notification delivery methods.
    /// </summary>
    public sealed partial class NotificationPreferenceSchema
    {
        /// <summary>
        /// Whether the user wants to receive live activities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("liveActivity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LiveActivity { get; set; }

        /// <summary>
        /// Whether the user wants to receive push notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushNotifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PushNotifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationPreferenceSchema" /> class.
        /// </summary>
        /// <param name="liveActivity">
        /// Whether the user wants to receive live activities.
        /// </param>
        /// <param name="pushNotifications">
        /// Whether the user wants to receive push notifications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotificationPreferenceSchema(
            bool liveActivity,
            bool pushNotifications)
        {
            this.LiveActivity = liveActivity;
            this.PushNotifications = pushNotifications;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationPreferenceSchema" /> class.
        /// </summary>
        public NotificationPreferenceSchema()
        {
        }

    }
}