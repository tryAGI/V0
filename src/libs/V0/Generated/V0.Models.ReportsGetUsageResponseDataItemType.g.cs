
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReportsGetUsageResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiRequest,
        /// <summary>
        /// 
        /// </summary>
        BuyTemplate,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        InlineEdit,
        /// <summary>
        /// 
        /// </summary>
        ManualDebit,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        RefundTemplatePurchase,
        /// <summary>
        /// 
        /// </summary>
        ReverseTemplateSale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReportsGetUsageResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportsGetUsageResponseDataItemType value)
        {
            return value switch
            {
                ReportsGetUsageResponseDataItemType.ApiRequest => "api_request",
                ReportsGetUsageResponseDataItemType.BuyTemplate => "buy-template",
                ReportsGetUsageResponseDataItemType.ImageGeneration => "image_generation",
                ReportsGetUsageResponseDataItemType.InlineEdit => "inline-edit",
                ReportsGetUsageResponseDataItemType.ManualDebit => "manual_debit",
                ReportsGetUsageResponseDataItemType.Message => "message",
                ReportsGetUsageResponseDataItemType.RefundTemplatePurchase => "refund_template_purchase",
                ReportsGetUsageResponseDataItemType.ReverseTemplateSale => "reverse_template_sale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportsGetUsageResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "api_request" => ReportsGetUsageResponseDataItemType.ApiRequest,
                "buy-template" => ReportsGetUsageResponseDataItemType.BuyTemplate,
                "image_generation" => ReportsGetUsageResponseDataItemType.ImageGeneration,
                "inline-edit" => ReportsGetUsageResponseDataItemType.InlineEdit,
                "manual_debit" => ReportsGetUsageResponseDataItemType.ManualDebit,
                "message" => ReportsGetUsageResponseDataItemType.Message,
                "refund_template_purchase" => ReportsGetUsageResponseDataItemType.RefundTemplatePurchase,
                "reverse_template_sale" => ReportsGetUsageResponseDataItemType.ReverseTemplateSale,
                _ => null,
            };
        }
    }
}