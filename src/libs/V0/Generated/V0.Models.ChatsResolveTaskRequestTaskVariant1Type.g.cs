
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatsResolveTaskRequestTaskVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        ConfirmedSteps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestTaskVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestTaskVariant1Type value)
        {
            return value switch
            {
                ChatsResolveTaskRequestTaskVariant1Type.ConfirmedSteps => "confirmed-steps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestTaskVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "confirmed-steps" => ChatsResolveTaskRequestTaskVariant1Type.ConfirmedSteps,
                _ => null,
            };
        }
    }
}