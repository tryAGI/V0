
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatsResolveTaskRequestTaskVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        ConfirmedPermissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestTaskVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestTaskVariant4Type value)
        {
            return value switch
            {
                ChatsResolveTaskRequestTaskVariant4Type.ConfirmedPermissions => "confirmed-permissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestTaskVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "confirmed-permissions" => ChatsResolveTaskRequestTaskVariant4Type.ConfirmedPermissions,
                _ => null,
            };
        }
    }
}