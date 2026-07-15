
#nullable enable

namespace V0
{
    /// <summary>
    /// The product's availability in v0. 'in-review' products only appear for teams with the review view and should be rendered as such.
    /// </summary>
    public enum ProductSummarySchemaV0Availability
    {
        /// <summary>
        /// 
        /// </summary>
        InReview,
        /// <summary>
        /// 
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProductSummarySchemaV0AvailabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProductSummarySchemaV0Availability value)
        {
            return value switch
            {
                ProductSummarySchemaV0Availability.InReview => "in-review",
                ProductSummarySchemaV0Availability.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProductSummarySchemaV0Availability? ToEnum(string value)
        {
            return value switch
            {
                "in-review" => ProductSummarySchemaV0Availability.InReview,
                "published" => ProductSummarySchemaV0Availability.Published,
                _ => null,
            };
        }
    }
}