
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName
    {
        /// <summary>
        /// 
        /// </summary>
        Contentful,
        /// <summary>
        /// 
        /// </summary>
        Context7,
        /// <summary>
        /// 
        /// </summary>
        Glean,
        /// <summary>
        /// 
        /// </summary>
        Granola,
        /// <summary>
        /// 
        /// </summary>
        Hex,
        /// <summary>
        /// 
        /// </summary>
        Linear,
        /// <summary>
        /// 
        /// </summary>
        Notion,
        /// <summary>
        /// 
        /// </summary>
        PostHog,
        /// <summary>
        /// 
        /// </summary>
        Sanity,
        /// <summary>
        /// 
        /// </summary>
        Sentry,
        /// <summary>
        /// 
        /// </summary>
        Slack,
        /// <summary>
        /// 
        /// </summary>
        Zapier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName value)
        {
            return value switch
            {
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Contentful => "Contentful",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Context7 => "Context7",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Glean => "Glean",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Granola => "Granola",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Hex => "Hex",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Linear => "Linear",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Notion => "Notion",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.PostHog => "PostHog",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Sanity => "Sanity",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Sentry => "Sentry",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Slack => "Slack",
                ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Zapier => "Zapier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName? ToEnum(string value)
        {
            return value switch
            {
                "Contentful" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Contentful,
                "Context7" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Context7,
                "Glean" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Glean,
                "Granola" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Granola,
                "Hex" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Hex,
                "Linear" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Linear,
                "Notion" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Notion,
                "PostHog" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.PostHog,
                "Sanity" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Sanity,
                "Sentry" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Sentry,
                "Slack" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Slack,
                "Zapier" => ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName.Zapier,
                _ => null,
            };
        }
    }
}