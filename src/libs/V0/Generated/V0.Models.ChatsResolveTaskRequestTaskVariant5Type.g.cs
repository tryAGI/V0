
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatsResolveTaskRequestTaskVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        VercelConnectSetup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestTaskVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestTaskVariant5Type value)
        {
            return value switch
            {
                ChatsResolveTaskRequestTaskVariant5Type.VercelConnectSetup => "vercel-connect-setup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestTaskVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel-connect-setup" => ChatsResolveTaskRequestTaskVariant5Type.VercelConnectSetup,
                _ => null,
            };
        }
    }
}