
#nullable enable

namespace V0
{
    /// <summary>
    /// When true, includes all default files (package.json, configuration files, etc.) that would be part of a complete deployment. When false or omitted, returns only the generated source files.
    /// </summary>
    public enum ChatsDownloadVersionIncludeDefaultFiles
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsDownloadVersionIncludeDefaultFilesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsDownloadVersionIncludeDefaultFiles value)
        {
            return value switch
            {
                ChatsDownloadVersionIncludeDefaultFiles.False => "false",
                ChatsDownloadVersionIncludeDefaultFiles.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsDownloadVersionIncludeDefaultFiles? ToEnum(string value)
        {
            return value switch
            {
                "false" => ChatsDownloadVersionIncludeDefaultFiles.False,
                "true" => ChatsDownloadVersionIncludeDefaultFiles.True,
                _ => null,
            };
        }
    }
}