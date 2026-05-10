
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsResolveTaskRequest
    {
        /// <summary>
        /// The task resolution data. The latest message in the active chat fork must be an assistant message blocked on the matching task type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.ChatsResolveTaskRequestTaskVariant1, global::V0.ChatsResolveTaskRequestTaskVariant2, global::V0.ChatsResolveTaskRequestTaskVariant3, global::V0.ChatsResolveTaskRequestTaskVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::V0.AnyOf<global::V0.ChatsResolveTaskRequestTaskVariant1, global::V0.ChatsResolveTaskRequestTaskVariant2, global::V0.ChatsResolveTaskRequestTaskVariant3, global::V0.ChatsResolveTaskRequestTaskVariant4> Task { get; set; }

        /// <summary>
        /// Controls how the response is delivered.<br/>
        /// - `"sync"`: The response is returned immediately with the HTTP request.<br/>
        /// - `"async"`: Returns a message placeholder immediately; use getById to poll for completion status and final output.<br/>
        /// - `"experimental_stream"`: Returns content parts as Server-Sent Events for real-time streaming.<br/>
        /// Default Value: sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsResolveTaskRequestResponseModeJsonConverter))]
        public global::V0.ChatsResolveTaskRequestResponseMode? ResponseMode { get; set; }

        /// <summary>
        /// Overrides for the model behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelConfiguration")]
        public global::V0.ChatsResolveTaskRequestModelConfiguration? ModelConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequest" /> class.
        /// </summary>
        /// <param name="task">
        /// The task resolution data. The latest message in the active chat fork must be an assistant message blocked on the matching task type.
        /// </param>
        /// <param name="responseMode">
        /// Controls how the response is delivered.<br/>
        /// - `"sync"`: The response is returned immediately with the HTTP request.<br/>
        /// - `"async"`: Returns a message placeholder immediately; use getById to poll for completion status and final output.<br/>
        /// - `"experimental_stream"`: Returns content parts as Server-Sent Events for real-time streaming.<br/>
        /// Default Value: sync
        /// </param>
        /// <param name="modelConfiguration">
        /// Overrides for the model behavior.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsResolveTaskRequest(
            global::V0.AnyOf<global::V0.ChatsResolveTaskRequestTaskVariant1, global::V0.ChatsResolveTaskRequestTaskVariant2, global::V0.ChatsResolveTaskRequestTaskVariant3, global::V0.ChatsResolveTaskRequestTaskVariant4> task,
            global::V0.ChatsResolveTaskRequestResponseMode? responseMode,
            global::V0.ChatsResolveTaskRequestModelConfiguration? modelConfiguration)
        {
            this.Task = task;
            this.ResponseMode = responseMode;
            this.ModelConfiguration = modelConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequest" /> class.
        /// </summary>
        public ChatsResolveTaskRequest()
        {
        }

    }
}