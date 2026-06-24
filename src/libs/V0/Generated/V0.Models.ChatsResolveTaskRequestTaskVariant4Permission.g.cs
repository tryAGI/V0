
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsResolveTaskRequestTaskVariant4Permission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant4PermissionTypeJsonConverter))]
        public global::V0.ChatsResolveTaskRequestTaskVariant4PermissionType Type { get; set; }

        /// <summary>
        /// The name of the tool being permitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// The tool call input arguments. Pass the exact input from the stopped task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Label shown while the tool is running (e.g. "Running migration").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskNameActive")]
        public string? TaskNameActive { get; set; }

        /// <summary>
        /// Label shown after the tool completes (e.g. "Migration complete").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskNameComplete")]
        public string? TaskNameComplete { get; set; }

        /// <summary>
        /// Optional message from the user about this permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userMessage")]
        public string? UserMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant4Permission" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the tool being permitted.
        /// </param>
        /// <param name="input">
        /// The tool call input arguments. Pass the exact input from the stopped task.
        /// </param>
        /// <param name="type"></param>
        /// <param name="taskNameActive">
        /// Label shown while the tool is running (e.g. "Running migration").
        /// </param>
        /// <param name="taskNameComplete">
        /// Label shown after the tool completes (e.g. "Migration complete").
        /// </param>
        /// <param name="userMessage">
        /// Optional message from the user about this permission.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsResolveTaskRequestTaskVariant4Permission(
            string toolName,
            object input,
            global::V0.ChatsResolveTaskRequestTaskVariant4PermissionType type,
            string? taskNameActive,
            string? taskNameComplete,
            string? userMessage)
        {
            this.Type = type;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.TaskNameActive = taskNameActive;
            this.TaskNameComplete = taskNameComplete;
            this.UserMessage = userMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsResolveTaskRequestTaskVariant4Permission" /> class.
        /// </summary>
        public ChatsResolveTaskRequestTaskVariant4Permission()
        {
        }

    }
}