
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReportsGetUserActivityResponseDataItemUserTeamV0Role2
    {
        /// <summary>
        /// 
        /// </summary>
        V0Builder,
        /// <summary>
        /// 
        /// </summary>
        V0Chatter,
        /// <summary>
        /// 
        /// </summary>
        V0Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReportsGetUserActivityResponseDataItemUserTeamV0Role2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportsGetUserActivityResponseDataItemUserTeamV0Role2 value)
        {
            return value switch
            {
                ReportsGetUserActivityResponseDataItemUserTeamV0Role2.V0Builder => "V0Builder",
                ReportsGetUserActivityResponseDataItemUserTeamV0Role2.V0Chatter => "V0Chatter",
                ReportsGetUserActivityResponseDataItemUserTeamV0Role2.V0Viewer => "V0Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportsGetUserActivityResponseDataItemUserTeamV0Role2? ToEnum(string value)
        {
            return value switch
            {
                "V0Builder" => ReportsGetUserActivityResponseDataItemUserTeamV0Role2.V0Builder,
                "V0Chatter" => ReportsGetUserActivityResponseDataItemUserTeamV0Role2.V0Chatter,
                "V0Viewer" => ReportsGetUserActivityResponseDataItemUserTeamV0Role2.V0Viewer,
                _ => null,
            };
        }
    }
}