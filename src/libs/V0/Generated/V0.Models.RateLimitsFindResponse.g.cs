
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitsFindResponse
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
        /// Daily message limit information for free users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyLimit")]
        public global::V0.RateLimitsFindResponseDailyLimit? DailyLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsFindResponse" /> class.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="remaining"></param>
        /// <param name="reset"></param>
        /// <param name="dailyLimit">
        /// Daily message limit information for free users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitsFindResponse(
            double limit,
            double? remaining,
            double? reset,
            global::V0.RateLimitsFindResponseDailyLimit? dailyLimit)
        {
            this.Remaining = remaining;
            this.Reset = reset;
            this.Limit = limit;
            this.DailyLimit = dailyLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsFindResponse" /> class.
        /// </summary>
        public RateLimitsFindResponse()
        {
        }
    }
}