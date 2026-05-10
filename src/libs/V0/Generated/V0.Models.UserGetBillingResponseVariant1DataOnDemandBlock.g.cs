
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetBillingResponseVariant1DataOnDemandBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public double? ExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectiveDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EffectiveDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalBalance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OriginalBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentBalance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentBalance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant1DataOnDemandBlock" /> class.
        /// </summary>
        /// <param name="effectiveDate"></param>
        /// <param name="originalBalance"></param>
        /// <param name="currentBalance"></param>
        /// <param name="expirationDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetBillingResponseVariant1DataOnDemandBlock(
            double effectiveDate,
            double originalBalance,
            double currentBalance,
            double? expirationDate)
        {
            this.ExpirationDate = expirationDate;
            this.EffectiveDate = effectiveDate;
            this.OriginalBalance = originalBalance;
            this.CurrentBalance = currentBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant1DataOnDemandBlock" /> class.
        /// </summary>
        public UserGetBillingResponseVariant1DataOnDemandBlock()
        {
        }

    }
}