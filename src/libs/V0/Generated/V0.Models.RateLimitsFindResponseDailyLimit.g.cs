
#nullable enable

namespace V0
{
    /// <summary>
    /// Daily message limit information for free users.
    /// </summary>
    public sealed partial class RateLimitsFindResponseDailyLimit
    {
        /// <summary>
        /// The maximum number of daily messages allowed for free users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// The number of messages the user has remaining for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Remaining { get; set; }

        /// <summary>
        /// Unix timestamp (in milliseconds) when the daily limit resets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Reset { get; set; }

        /// <summary>
        /// Whether the user is within the 48-hour grace period for new users, during which usage tracking is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isWithinGracePeriod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsWithinGracePeriod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsFindResponseDailyLimit" /> class.
        /// </summary>
        /// <param name="limit">
        /// The maximum number of daily messages allowed for free users.
        /// </param>
        /// <param name="remaining">
        /// The number of messages the user has remaining for the day.
        /// </param>
        /// <param name="reset">
        /// Unix timestamp (in milliseconds) when the daily limit resets.
        /// </param>
        /// <param name="isWithinGracePeriod">
        /// Whether the user is within the 48-hour grace period for new users, during which usage tracking is disabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitsFindResponseDailyLimit(
            double limit,
            double remaining,
            double reset,
            bool isWithinGracePeriod)
        {
            this.Limit = limit;
            this.Remaining = remaining;
            this.Reset = reset;
            this.IsWithinGracePeriod = isWithinGracePeriod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsFindResponseDailyLimit" /> class.
        /// </summary>
        public RateLimitsFindResponseDailyLimit()
        {
        }

    }
}