
#nullable enable

namespace V0
{
    /// <summary>
    /// When true, includes all default files (package.json, configuration files, etc.) that would be part of a ZIP download. When false or omitted, returns only the generated source files.
    /// </summary>
    public enum ChatsGetVersionIncludeDefaultFiles
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
    public static class ChatsGetVersionIncludeDefaultFilesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsGetVersionIncludeDefaultFiles value)
        {
            return value switch
            {
                ChatsGetVersionIncludeDefaultFiles.False => "false",
                ChatsGetVersionIncludeDefaultFiles.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsGetVersionIncludeDefaultFiles? ToEnum(string value)
        {
            return value switch
            {
                "false" => ChatsGetVersionIncludeDefaultFiles.False,
                "true" => ChatsGetVersionIncludeDefaultFiles.True,
                _ => null,
            };
        }
    }
}