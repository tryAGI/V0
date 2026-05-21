
#nullable enable

namespace V0
{
    /// <summary>
    /// Detailed information for an environment variable including its value.
    /// </summary>
    public sealed partial class EnvironmentVariablesListSchemaDataItem
    {
        /// <summary>
        /// A unique identifier for the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        /// <default>"environment_variable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "environment_variable";

        /// <summary>
        /// The name of the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The value of the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Whether the value is decrypted or encrypted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decrypted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Decrypted { get; set; }

        /// <summary>
        /// The timestamp when the environment variable was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the environment variable was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariablesListSchemaDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the environment variable.
        /// </param>
        /// <param name="key">
        /// The name of the environment variable.
        /// </param>
        /// <param name="value">
        /// The value of the environment variable.
        /// </param>
        /// <param name="decrypted">
        /// Whether the value is decrypted or encrypted.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the environment variable was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the environment variable was last updated.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentVariablesListSchemaDataItem(
            string id,
            string key,
            string value,
            bool decrypted,
            double createdAt,
            double? updatedAt,
            string @object = "environment_variable")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Decrypted = decrypted;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariablesListSchemaDataItem" /> class.
        /// </summary>
        public EnvironmentVariablesListSchemaDataItem()
        {
        }

    }
}