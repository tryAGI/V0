
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetBillingResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"token"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingType")]
        public string BillingType { get; set; } = "token";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.UserGetBillingResponseVariant1Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant1" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="billingType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetBillingResponseVariant1(
            global::V0.UserGetBillingResponseVariant1Data data,
            string billingType = "token")
        {
            this.BillingType = billingType;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetBillingResponseVariant1" /> class.
        /// </summary>
        public UserGetBillingResponseVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="UserGetBillingResponseVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static UserGetBillingResponseVariant1 FromData(global::V0.UserGetBillingResponseVariant1Data data)
        {
            return new UserGetBillingResponseVariant1
            {
                Data = data,
            };
        }

    }
}