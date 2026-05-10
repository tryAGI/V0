
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetBillingResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"legacy"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingType")]
        public string BillingType { get; set; } = "legacy";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.UserGetBillingResponseVariant2Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="billingType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetBillingResponseVariant2(
            global::V0.UserGetBillingResponseVariant2Data data,
            string billingType = "legacy")
        {
            this.BillingType = billingType;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant2" /> class.
        /// </summary>
        public UserGetBillingResponseVariant2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="UserGetBillingResponseVariant2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static UserGetBillingResponseVariant2 FromData(global::V0.UserGetBillingResponseVariant2Data data)
        {
            return new UserGetBillingResponseVariant2
            {
                Data = data,
            };
        }

    }
}