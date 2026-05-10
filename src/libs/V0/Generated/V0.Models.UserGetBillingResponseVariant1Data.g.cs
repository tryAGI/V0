
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetBillingResponseVariant1Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingMode")]
        public string? BillingMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingCycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.UserGetBillingResponseVariant1DataBillingCycle BillingCycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.UserGetBillingResponseVariant1DataBalance Balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onDemand")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.UserGetBillingResponseVariant1DataOnDemand OnDemand { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant1Data" /> class.
        /// </summary>
        /// <param name="plan"></param>
        /// <param name="role"></param>
        /// <param name="billingCycle"></param>
        /// <param name="balance"></param>
        /// <param name="onDemand"></param>
        /// <param name="billingMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetBillingResponseVariant1Data(
            string plan,
            string role,
            global::V0.UserGetBillingResponseVariant1DataBillingCycle billingCycle,
            global::V0.UserGetBillingResponseVariant1DataBalance balance,
            global::V0.UserGetBillingResponseVariant1DataOnDemand onDemand,
            string? billingMode)
        {
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.BillingMode = billingMode;
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.BillingCycle = billingCycle ?? throw new global::System.ArgumentNullException(nameof(billingCycle));
            this.Balance = balance ?? throw new global::System.ArgumentNullException(nameof(balance));
            this.OnDemand = onDemand ?? throw new global::System.ArgumentNullException(nameof(onDemand));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant1Data" /> class.
        /// </summary>
        public UserGetBillingResponseVariant1Data()
        {
        }

    }
}