
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatsResolveTaskRequestTaskVariant4PermissionType
    {
        /// <summary>
        /// 
        /// </summary>
        AllowDynamicToolStrict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestTaskVariant4PermissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestTaskVariant4PermissionType value)
        {
            return value switch
            {
                ChatsResolveTaskRequestTaskVariant4PermissionType.AllowDynamicToolStrict => "ALLOW_DYNAMIC_TOOL_STRICT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestTaskVariant4PermissionType? ToEnum(string value)
        {
            return value switch
            {
                "ALLOW_DYNAMIC_TOOL_STRICT" => ChatsResolveTaskRequestTaskVariant4PermissionType.AllowDynamicToolStrict,
                _ => null,
            };
        }
    }
}