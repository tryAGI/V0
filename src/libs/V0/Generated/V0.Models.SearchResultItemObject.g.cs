
#nullable enable

namespace V0
{
    /// <summary>
    /// Type of item returned, either 'chat' or 'project'.
    /// </summary>
    public enum SearchResultItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResultItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResultItemObject value)
        {
            return value switch
            {
                SearchResultItemObject.Chat => "chat",
                SearchResultItemObject.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResultItemObject? ToEnum(string value)
        {
            return value switch
            {
                "chat" => SearchResultItemObject.Chat,
                "project" => SearchResultItemObject.Project,
                _ => null,
            };
        }
    }
}