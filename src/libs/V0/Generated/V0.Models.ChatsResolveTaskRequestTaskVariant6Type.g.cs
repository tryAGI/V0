
#nullable enable

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatsResolveTaskRequestTaskVariant6Type
    {
        /// <summary>
        ///
        /// </summary>
        VercelConnectAuthorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestTaskVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestTaskVariant6Type value)
        {
            return value switch
            {
                ChatsResolveTaskRequestTaskVariant6Type.VercelConnectAuthorization => "vercel-connect-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestTaskVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel-connect-authorization" => ChatsResolveTaskRequestTaskVariant6Type.VercelConnectAuthorization,
                _ => null,
            };
        }
    }
}