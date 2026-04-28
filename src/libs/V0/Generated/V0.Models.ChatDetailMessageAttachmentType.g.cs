
#nullable enable

namespace V0
{
    /// <summary>
    /// Optional v0-specific attachment type for enhanced processing.
    /// </summary>
    public enum ChatDetailMessageAttachmentType
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
    public static class ChatDetailMessageAttachmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatDetailMessageAttachmentType value)
        {
            return value switch
            {
                ChatDetailMessageAttachmentType.Figma => "figma",
                ChatDetailMessageAttachmentType.Screenshot => "screenshot",
                ChatDetailMessageAttachmentType.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatDetailMessageAttachmentType? ToEnum(string value)
        {
            return value switch
            {
                "figma" => ChatDetailMessageAttachmentType.Figma,
                "screenshot" => ChatDetailMessageAttachmentType.Screenshot,
                "zip" => ChatDetailMessageAttachmentType.Zip,
                _ => null,
            };
        }
    }
}