
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsStopResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsStopResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsStopResponse(
            bool success = true)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsStopResponse" /> class.
        /// </summary>
        public ChatsStopResponse()
        {
        }

    }
}