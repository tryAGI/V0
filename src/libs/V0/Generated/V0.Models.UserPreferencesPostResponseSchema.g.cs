
#nullable enable

namespace V0
{
    /// <summary>
    /// Response schema for updating user preferences.
    /// </summary>
    public sealed partial class UserPreferencesPostResponseSchema
    {
        /// <summary>
        /// Object type identifier.
        /// </summary>
        /// <default>"user_preferences"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "user_preferences";

        /// <summary>
        /// The updated preferences if successful, or null if failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferences")]
        public global::V0.UserPreferencesPostResponseSchemaPreferences2? Preferences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesPostResponseSchema" /> class.
        /// </summary>
        /// <param name="preferences">
        /// The updated preferences if successful, or null if failed.
        /// </param>
        /// <param name="object">
        /// Object type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserPreferencesPostResponseSchema(
            global::V0.UserPreferencesPostResponseSchemaPreferences2? preferences,
            string @object = "user_preferences")
        {
            this.Object = @object;
            this.Preferences = preferences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesPostResponseSchema" /> class.
        /// </summary>
        public UserPreferencesPostResponseSchema()
        {
        }

    }
}