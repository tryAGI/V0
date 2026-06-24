
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatsResolveTaskRequestTaskVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        AnsweredQuestions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestTaskVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestTaskVariant3Type value)
        {
            return value switch
            {
                ChatsResolveTaskRequestTaskVariant3Type.AnsweredQuestions => "answered-questions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestTaskVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "answered-questions" => ChatsResolveTaskRequestTaskVariant3Type.AnsweredQuestions,
                _ => null,
            };
        }
    }
}