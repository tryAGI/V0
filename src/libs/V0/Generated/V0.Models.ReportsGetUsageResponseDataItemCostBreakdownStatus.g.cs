
#nullable enable

namespace V0
{
    /// <summary>
    /// Whether the cost components are estimated or unavailable. Unavailable components are omitted; totalCost remains authoritative.
    /// </summary>
    public enum ReportsGetUsageResponseDataItemCostBreakdownStatus
    {
        /// <summary>
        ///
        /// </summary>
        Estimated,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReportsGetUsageResponseDataItemCostBreakdownStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportsGetUsageResponseDataItemCostBreakdownStatus value)
        {
            return value switch
            {
                ReportsGetUsageResponseDataItemCostBreakdownStatus.Estimated => "estimated",
                ReportsGetUsageResponseDataItemCostBreakdownStatus.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportsGetUsageResponseDataItemCostBreakdownStatus? ToEnum(string value)
        {
            return value switch
            {
                "estimated" => ReportsGetUsageResponseDataItemCostBreakdownStatus.Estimated,
                "unavailable" => ReportsGetUsageResponseDataItemCostBreakdownStatus.Unavailable,
                _ => null,
            };
        }
    }
}