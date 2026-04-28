
#nullable enable

namespace V0
{
    /// <summary>
    /// Optional v0-specific attachment type for enhanced processing.
    /// </summary>
    public enum MessageSummaryAttachmentType
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
    public static class MessageSummaryAttachmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSummaryAttachmentType value)
        {
            return value switch
            {
                MessageSummaryAttachmentType.Figma => "figma",
                MessageSummaryAttachmentType.Screenshot => "screenshot",
                MessageSummaryAttachmentType.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSummaryAttachmentType? ToEnum(string value)
        {
            return value switch
            {
                "figma" => MessageSummaryAttachmentType.Figma,
                "screenshot" => MessageSummaryAttachmentType.Screenshot,
                "zip" => MessageSummaryAttachmentType.Zip,
                _ => null,
            };
        }
    }
}