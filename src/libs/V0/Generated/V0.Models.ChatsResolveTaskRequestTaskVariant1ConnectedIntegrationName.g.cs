
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName
    {
        /// <summary>
        /// 
        /// </summary>
        AmazonAuroraDsql,
        /// <summary>
        /// 
        /// </summary>
        AmazonAuroraPostgreSQL,
        /// <summary>
        /// 
        /// </summary>
        AmazonDynamoDB,
        /// <summary>
        /// 
        /// </summary>
        Blob,
        /// <summary>
        /// 
        /// </summary>
        Clerk,
        /// <summary>
        /// 
        /// </summary>
        Convex,
        /// <summary>
        /// 
        /// </summary>
        DeepInfra,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfig,
        /// <summary>
        /// 
        /// </summary>
        Grok,
        /// <summary>
        /// 
        /// </summary>
        Neon,
        /// <summary>
        /// 
        /// </summary>
        Shopify,
        /// <summary>
        /// 
        /// </summary>
        Snowflake,
        /// <summary>
        /// 
        /// </summary>
        Stripe,
        /// <summary>
        /// 
        /// </summary>
        Supabase,
        /// <summary>
        /// 
        /// </summary>
        UpstashSearch,
        /// <summary>
        /// 
        /// </summary>
        UpstashForRedis,
        /// <summary>
        /// 
        /// </summary>
        VercelAiGateway,
        /// <summary>
        /// 
        /// </summary>
        Fal,
        /// <summary>
        /// 
        /// </summary>
        Firebase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName value)
        {
            return value switch
            {
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.AmazonAuroraDsql => "Amazon Aurora DSQL",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.AmazonAuroraPostgreSQL => "Amazon Aurora PostgreSQL",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.AmazonDynamoDB => "Amazon DynamoDB",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Blob => "Blob",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Clerk => "Clerk",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Convex => "Convex",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.DeepInfra => "Deep Infra",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.EdgeConfig => "Edge Config",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Grok => "Grok",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Neon => "Neon",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Shopify => "Shopify",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Snowflake => "Snowflake",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Stripe => "Stripe",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Supabase => "Supabase",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.UpstashSearch => "Upstash Search",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.UpstashForRedis => "Upstash for Redis",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.VercelAiGateway => "Vercel AI Gateway",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Fal => "fal",
                ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Firebase => "firebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName? ToEnum(string value)
        {
            return value switch
            {
                "Amazon Aurora DSQL" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.AmazonAuroraDsql,
                "Amazon Aurora PostgreSQL" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.AmazonAuroraPostgreSQL,
                "Amazon DynamoDB" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.AmazonDynamoDB,
                "Blob" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Blob,
                "Clerk" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Clerk,
                "Convex" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Convex,
                "Deep Infra" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.DeepInfra,
                "Edge Config" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.EdgeConfig,
                "Grok" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Grok,
                "Neon" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Neon,
                "Shopify" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Shopify,
                "Snowflake" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Snowflake,
                "Stripe" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Stripe,
                "Supabase" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Supabase,
                "Upstash Search" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.UpstashSearch,
                "Upstash for Redis" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.UpstashForRedis,
                "Vercel AI Gateway" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.VercelAiGateway,
                "fal" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Fal,
                "firebase" => ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName.Firebase,
                _ => null,
            };
        }
    }
}