
#nullable enable

namespace V0
{
    /// <summary>
    /// User preferences configuration including notification settings.
    /// </summary>
    public sealed partial class UserPreferencesSchema
    {
        /// <summary>
        /// The user's preferred method for receiving notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.UserPreferencesSchemaNotifications Notifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesSchema" /> class.
        /// </summary>
        /// <param name="notifications">
        /// The user's preferred method for receiving notifications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserPreferencesSchema(
            global::V0.UserPreferencesSchemaNotifications notifications)
        {
            this.Notifications = notifications ?? throw new global::System.ArgumentNullException(nameof(notifications));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesSchema" /> class.
        /// </summary>
        public UserPreferencesSchema()
        {
        }
    }
}