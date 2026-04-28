#nullable enable

namespace V0.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatDetailModelConfigurationModelIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::V0.ChatDetailModelConfigurationModelId>
    {
        /// <inheritdoc />
        public override global::V0.ChatDetailModelConfigurationModelId Read(
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
                        return global::V0.ChatDetailModelConfigurationModelIdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::V0.ChatDetailModelConfigurationModelId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::V0.ChatDetailModelConfigurationModelId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::V0.ChatDetailModelConfigurationModelId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::V0.ChatDetailModelConfigurationModelIdExtensions.ToValueString(value));
        }
    }
}
