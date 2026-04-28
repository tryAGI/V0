
#nullable enable

namespace V0
{
    /// <summary>
    /// If true, deletes all the chats associated with the given project ID. Deleting is permanent. Defaults to false.<br/>
    /// Default Value: false
    /// </summary>
    public enum ProjectsDeleteDeleteAllChats
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
    public static class ProjectsDeleteDeleteAllChatsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsDeleteDeleteAllChats value)
        {
            return value switch
            {
                ProjectsDeleteDeleteAllChats.False => "false",
                ProjectsDeleteDeleteAllChats.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsDeleteDeleteAllChats? ToEnum(string value)
        {
            return value switch
            {
                "false" => ProjectsDeleteDeleteAllChats.False,
                "true" => ProjectsDeleteDeleteAllChats.True,
                _ => null,
            };
        }
    }
}