
#nullable enable

namespace V0
{
    /// <summary>
    /// Response schema for retrieving user preferences.
    /// </summary>
    public sealed partial class UserPreferencesResponseSchema
    {
        /// <summary>
        /// Object type identifier.
        /// </summary>
        /// <default>"user_preferences"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "user_preferences";

        /// <summary>
        /// The user's current preferences, or null if errored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferences")]
        public global::V0.UserPreferencesResponseSchemaPreferences2? Preferences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesResponseSchema" /> class.
        /// </summary>
        /// <param name="preferences">
        /// The user's current preferences, or null if errored.
        /// </param>
        /// <param name="object">
        /// Object type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserPreferencesResponseSchema(
            global::V0.UserPreferencesResponseSchemaPreferences2? preferences,
            string @object = "user_preferences")
        {
            this.Object = @object;
            this.Preferences = preferences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesResponseSchema" /> class.
        /// </summary>
        public UserPreferencesResponseSchema()
        {
        }

    }
}