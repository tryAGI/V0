
#nullable enable

namespace V0
{
    /// <summary>
    /// The product's availability in v0. 'in-review' products only appear for teams with the review view and should be rendered as such.
    /// </summary>
    public enum ProductListSchemaDataItemV0Availability
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
    public static class ProductListSchemaDataItemV0AvailabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProductListSchemaDataItemV0Availability value)
        {
            return value switch
            {
                ProductListSchemaDataItemV0Availability.InReview => "in-review",
                ProductListSchemaDataItemV0Availability.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProductListSchemaDataItemV0Availability? ToEnum(string value)
        {
            return value switch
            {
                "in-review" => ProductListSchemaDataItemV0Availability.InReview,
                "published" => ProductListSchemaDataItemV0Availability.Published,
                _ => null,
            };
        }
    }
}