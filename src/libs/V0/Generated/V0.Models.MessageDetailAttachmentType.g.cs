
#nullable enable

namespace V0
{
    /// <summary>
    /// Optional v0-specific attachment type for enhanced processing.
    /// </summary>
    public enum MessageDetailAttachmentType
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
    public static class MessageDetailAttachmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDetailAttachmentType value)
        {
            return value switch
            {
                MessageDetailAttachmentType.Figma => "figma",
                MessageDetailAttachmentType.Screenshot => "screenshot",
                MessageDetailAttachmentType.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDetailAttachmentType? ToEnum(string value)
        {
            return value switch
            {
                "figma" => MessageDetailAttachmentType.Figma,
                "screenshot" => MessageDetailAttachmentType.Screenshot,
                "zip" => MessageDetailAttachmentType.Zip,
                _ => null,
            };
        }
    }
}