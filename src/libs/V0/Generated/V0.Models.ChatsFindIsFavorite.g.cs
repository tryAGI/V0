
#nullable enable

namespace V0
{
    /// <summary>
    /// Filters chats by their "favorite" status. Accepts `"true"` or `"false"` (as strings, not booleans).<br/>
    /// - `"true"`: returns only chats marked as favorites.<br/>
    /// - `"false"`: returns only non-favorite chats.
    /// </summary>
    public enum ChatsFindIsFavorite
    {
        /// <summary>
        /// returns only non-favorite chats.
        /// </summary>
        False,
        /// <summary>
        /// returns only chats marked as favorites.
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsFindIsFavoriteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsFindIsFavorite value)
        {
            return value switch
            {
                ChatsFindIsFavorite.False => "false",
                ChatsFindIsFavorite.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsFindIsFavorite? ToEnum(string value)
        {
            return value switch
            {
                "false" => ChatsFindIsFavorite.False,
                "true" => ChatsFindIsFavorite.True,
                _ => null,
            };
        }
    }
}