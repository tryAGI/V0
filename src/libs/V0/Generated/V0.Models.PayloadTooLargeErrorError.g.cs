
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PayloadTooLargeErrorError
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
        /// <default>"payload_too_large_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "payload_too_large_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadTooLargeErrorError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayloadTooLargeErrorError(
            string message,
            string type = "payload_too_large_error")
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadTooLargeErrorError" /> class.
        /// </summary>
        public PayloadTooLargeErrorError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PayloadTooLargeErrorError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PayloadTooLargeErrorError FromMessage(string message)
        {
            return new PayloadTooLargeErrorError
            {
                Message = message,
            };
        }

    }
}