#nullable enable

namespace V0.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageSummaryAttachmentTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::V0.MessageSummaryAttachmentType>
    {
        /// <inheritdoc />
        public override global::V0.MessageSummaryAttachmentType Read(
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
                        return global::V0.MessageSummaryAttachmentTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::V0.MessageSummaryAttachmentType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::V0.MessageSummaryAttachmentType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::V0.MessageSummaryAttachmentType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::V0.MessageSummaryAttachmentTypeExtensions.ToValueString(value));
        }
    }
}
