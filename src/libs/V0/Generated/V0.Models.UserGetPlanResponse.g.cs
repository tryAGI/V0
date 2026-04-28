
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetPlanResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"plan"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "plan";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingCycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.UserGetPlanResponseBillingCycle BillingCycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.UserGetPlanResponseBalance Balance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetPlanResponse" /> class.
        /// </summary>
        /// <param name="plan"></param>
        /// <param name="billingCycle"></param>
        /// <param name="balance"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetPlanResponse(
            string plan,
            global::V0.UserGetPlanResponseBillingCycle billingCycle,
            global::V0.UserGetPlanResponseBalance balance,
            string @object = "plan")
        {
            this.Object = @object;
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.BillingCycle = billingCycle ?? throw new global::System.ArgumentNullException(nameof(billingCycle));
            this.Balance = balance ?? throw new global::System.ArgumentNullException(nameof(balance));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetPlanResponse" /> class.
        /// </summary>
        public UserGetPlanResponse()
        {
        }
    }
}