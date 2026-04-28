
#nullable enable

namespace V0
{
    /// <summary>
    /// The delivery status of the webhook (e.g., delivered, failed).<br/>
    /// Default Value: pending
    /// </summary>
    public enum HookEventDetailStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HookEventDetailStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HookEventDetailStatus value)
        {
            return value switch
            {
                HookEventDetailStatus.Error => "error",
                HookEventDetailStatus.Pending => "pending",
                HookEventDetailStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HookEventDetailStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => HookEventDetailStatus.Error,
                "pending" => HookEventDetailStatus.Pending,
                "success" => HookEventDetailStatus.Success,
                _ => null,
            };
        }
    }
}