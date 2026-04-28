
#nullable enable

namespace V0
{
    /// <summary>
    /// The archive format for the download. Choose "zip" for broad compatibility or "tarball" for Unix/Linux systems.<br/>
    /// Default Value: zip
    /// </summary>
    public enum ChatsDownloadVersionFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Tarball,
        /// <summary>
        /// 
        /// </summary>
        Zip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsDownloadVersionFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsDownloadVersionFormat value)
        {
            return value switch
            {
                ChatsDownloadVersionFormat.Tarball => "tarball",
                ChatsDownloadVersionFormat.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsDownloadVersionFormat? ToEnum(string value)
        {
            return value switch
            {
                "tarball" => ChatsDownloadVersionFormat.Tarball,
                "zip" => ChatsDownloadVersionFormat.Zip,
                _ => null,
            };
        }
    }
}