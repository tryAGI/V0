
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsFindErrorsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullErrorText")]
        public string? FullErrorText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorType")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formattedError")]
        public string? FormattedError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsFindErrorsResponse" /> class.
        /// </summary>
        /// <param name="fullErrorText"></param>
        /// <param name="errorType"></param>
        /// <param name="formattedError"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentsFindErrorsResponse(
            string? fullErrorText,
            string? errorType,
            string? formattedError)
        {
            this.FullErrorText = fullErrorText;
            this.ErrorType = errorType;
            this.FormattedError = formattedError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsFindErrorsResponse" /> class.
        /// </summary>
        public DeploymentsFindErrorsResponse()
        {
        }
    }
}