
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatsResolveTaskRequestTaskVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        PlanExitResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestTaskVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestTaskVariant2Type value)
        {
            return value switch
            {
                ChatsResolveTaskRequestTaskVariant2Type.PlanExitResponse => "plan-exit-response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestTaskVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "plan-exit-response" => ChatsResolveTaskRequestTaskVariant2Type.PlanExitResponse,
                _ => null,
            };
        }
    }
}