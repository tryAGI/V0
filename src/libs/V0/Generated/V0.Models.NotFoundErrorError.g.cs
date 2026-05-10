
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotFoundErrorError
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
        /// <default>"not_found_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "not_found_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundErrorError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotFoundErrorError(
            string message,
            string type = "not_found_error")
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundErrorError" /> class.
        /// </summary>
        public NotFoundErrorError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NotFoundErrorError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NotFoundErrorError FromMessage(string message)
        {
            return new NotFoundErrorError
            {
                Message = message,
            };
        }

    }
}