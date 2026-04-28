
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetBillingResponseVariant1DataOnDemand
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        public global::System.Collections.Generic.IList<global::V0.UserGetBillingResponseVariant1DataOnDemandBlock>? Blocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant1DataOnDemand" /> class.
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="blocks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetBillingResponseVariant1DataOnDemand(
            double balance,
            global::System.Collections.Generic.IList<global::V0.UserGetBillingResponseVariant1DataOnDemandBlock>? blocks)
        {
            this.Balance = balance;
            this.Blocks = blocks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant1DataOnDemand" /> class.
        /// </summary>
        public UserGetBillingResponseVariant1DataOnDemand()
        {
        }
    }
}