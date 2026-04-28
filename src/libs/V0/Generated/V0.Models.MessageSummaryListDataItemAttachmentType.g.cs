
#nullable enable

namespace V0
{
    /// <summary>
    /// Optional v0-specific attachment type for enhanced processing.
    /// </summary>
    public enum MessageSummaryListDataItemAttachmentType
    {
        /// <summary>
        /// 
        /// </summary>
        Figma,
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
        /// <summary>
        /// 
        /// </summary>
        Zip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageSummaryListDataItemAttachmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSummaryListDataItemAttachmentType value)
        {
            return value switch
            {
                MessageSummaryListDataItemAttachmentType.Figma => "figma",
                MessageSummaryListDataItemAttachmentType.Screenshot => "screenshot",
                MessageSummaryListDataItemAttachmentType.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSummaryListDataItemAttachmentType? ToEnum(string value)
        {
            return value switch
            {
                "figma" => MessageSummaryListDataItemAttachmentType.Figma,
                "screenshot" => MessageSummaryListDataItemAttachmentType.Screenshot,
                "zip" => MessageSummaryListDataItemAttachmentType.Zip,
                _ => null,
            };
        }
    }
}