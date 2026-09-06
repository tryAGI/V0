#nullable enable

namespace V0.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatsSendMessageRequestModelConfigurationThinkingEffortNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::V0.ChatsSendMessageRequestModelConfigurationThinkingEffort?>
    {
        /// <inheritdoc />
        public override global::V0.ChatsSendMessageRequestModelConfigurationThinkingEffort? Read(
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
                        return global::V0.ChatsSendMessageRequestModelConfigurationThinkingEffortExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::V0.ChatsSendMessageRequestModelConfigurationThinkingEffort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::V0.ChatsSendMessageRequestModelConfigurationThinkingEffort?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::V0.ChatsSendMessageRequestModelConfigurationThinkingEffort? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::V0.ChatsSendMessageRequestModelConfigurationThinkingEffortExtensions.ToValueString(value.Value));
            }
        }
    }
}
