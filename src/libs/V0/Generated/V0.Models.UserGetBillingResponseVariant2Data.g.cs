
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetBillingResponseVariant2Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public double? Remaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset")]
        public double? Reset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant2Data" /> class.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="remaining"></param>
        /// <param name="reset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetBillingResponseVariant2Data(
            double limit,
            double? remaining,
            double? reset)
        {
            this.Remaining = remaining;
            this.Reset = reset;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant2Data" /> class.
        /// </summary>
        public UserGetBillingResponseVariant2Data()
        {
        }

    }
}