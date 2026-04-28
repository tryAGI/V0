#nullable enable

namespace V0.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatsCreateRequestChatPrivacyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::V0.ChatsCreateRequestChatPrivacy>
    {
        /// <inheritdoc />
        public override global::V0.ChatsCreateRequestChatPrivacy Read(
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
                        return global::V0.ChatsCreateRequestChatPrivacyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::V0.ChatsCreateRequestChatPrivacy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::V0.ChatsCreateRequestChatPrivacy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::V0.ChatsCreateRequestChatPrivacy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::V0.ChatsCreateRequestChatPrivacyExtensions.ToValueString(value));
        }
    }
}
