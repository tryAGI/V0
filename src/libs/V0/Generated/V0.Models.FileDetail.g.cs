
#nullable enable

namespace V0
{
    /// <summary>
    /// Detailed representation of a file, including its content and lock status.
    /// </summary>
    public sealed partial class FileDetail
    {
        /// <summary>
        /// Fixed value identifying this object as a file.
        /// </summary>
        /// <default>"file"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "file";

        /// <summary>
        /// The name of the file, including its extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The full contents of the file as a raw string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Whether the file is locked to prevent AI from overwriting it during new version generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Locked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileDetail" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the file, including its extension.
        /// </param>
        /// <param name="content">
        /// The full contents of the file as a raw string.
        /// </param>
        /// <param name="locked">
        /// Whether the file is locked to prevent AI from overwriting it during new version generation.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileDetail(
            string name,
            string content,
            bool locked,
            string @object = "file")
        {
            this.Object = @object;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Locked = locked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileDetail" /> class.
        /// </summary>
        public FileDetail()
        {
        }
    }
}