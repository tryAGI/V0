
#nullable enable

namespace V0
{
    /// <summary>
    /// Whether the plan is approved, rejected, or needs changes.
    /// </summary>
    public enum ChatsResolveTaskRequestTaskVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        RequestChanges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestTaskVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestTaskVariant2Status value)
        {
            return value switch
            {
                ChatsResolveTaskRequestTaskVariant2Status.Approved => "approved",
                ChatsResolveTaskRequestTaskVariant2Status.Rejected => "rejected",
                ChatsResolveTaskRequestTaskVariant2Status.RequestChanges => "request-changes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestTaskVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "approved" => ChatsResolveTaskRequestTaskVariant2Status.Approved,
                "rejected" => ChatsResolveTaskRequestTaskVariant2Status.Rejected,
                "request-changes" => ChatsResolveTaskRequestTaskVariant2Status.RequestChanges,
                _ => null,
            };
        }
    }
}