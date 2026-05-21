
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnprocessableEntityErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"unprocessable_entity_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "unprocessable_entity_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnprocessableEntityErrorError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnprocessableEntityErrorError(
            string message,
            string type = "unprocessable_entity_error")
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnprocessableEntityErrorError" /> class.
        /// </summary>
        public UnprocessableEntityErrorError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="UnprocessableEntityErrorError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static UnprocessableEntityErrorError FromMessage(string message)
        {
            return new UnprocessableEntityErrorError
            {
                Message = message,
            };
        }

    }
}