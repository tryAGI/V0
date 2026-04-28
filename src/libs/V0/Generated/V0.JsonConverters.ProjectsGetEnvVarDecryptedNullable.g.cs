#nullable enable

namespace V0.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectsGetEnvVarDecryptedNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::V0.ProjectsGetEnvVarDecrypted?>
    {
        /// <inheritdoc />
        public override global::V0.ProjectsGetEnvVarDecrypted? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::V0.ProjectsGetEnvVarDecryptedExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::V0.ProjectsGetEnvVarDecrypted)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::V0.ProjectsGetEnvVarDecrypted?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::V0.ProjectsGetEnvVarDecrypted? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::V0.ProjectsGetEnvVarDecryptedExtensions.ToValueString(value.Value));
            }
        }
    }
}
