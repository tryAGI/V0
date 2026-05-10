
#nullable enable

namespace V0
{
    /// <summary>
    /// Resolves an integration installation task. The agent asked the user to install integrations, MCP presets, or set environment variables. Send this after provisioning the integration on Vercel.
    /// </summary>
    public sealed partial class ChatsResolveTaskRequestTaskVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"confirmed-steps"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "confirmed-steps";

        /// <summary>
        /// Names of integrations that were successfully connected (e.g. "Neon", "Supabase"). Pass an empty array to skip.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedIntegrationNames")]
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName>? ConnectedIntegrationNames { get; set; }

        /// <summary>
        /// Names of MCP presets that were connected (e.g. "Linear", "Sentry"). Pass an empty array to skip.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedMcpPresetNames")]
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName>? ConnectedMcpPresetNames { get; set; }

        /// <summary>
        /// Names of scripts that were applied.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedScripts")]
        public global::System.Collections.Generic.IList<string>? AppliedScripts { get; set; }

        /// <summary>
        /// Names of environment variables that were added.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedEnvVars")]
        public global::System.Collections.Generic.IList<string>? AddedEnvVars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant1" /> class.
        /// </summary>
        /// <param name="connectedIntegrationNames">
        /// Names of integrations that were successfully connected (e.g. "Neon", "Supabase"). Pass an empty array to skip.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="connectedMcpPresetNames">
        /// Names of MCP presets that were connected (e.g. "Linear", "Sentry"). Pass an empty array to skip.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="appliedScripts">
        /// Names of scripts that were applied.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="addedEnvVars">
        /// Names of environment variables that were added.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsResolveTaskRequestTaskVariant1(
            global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedIntegrationName>? connectedIntegrationNames,
            global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName>? connectedMcpPresetNames,
            global::System.Collections.Generic.IList<string>? appliedScripts,
            global::System.Collections.Generic.IList<string>? addedEnvVars,
            string type = "confirmed-steps")
        {
            this.Type = type;
            this.ConnectedIntegrationNames = connectedIntegrationNames;
            this.ConnectedMcpPresetNames = connectedMcpPresetNames;
            this.AppliedScripts = appliedScripts;
            this.AddedEnvVars = addedEnvVars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant1" /> class.
        /// </summary>
        public ChatsResolveTaskRequestTaskVariant1()
        {
        }

    }
}