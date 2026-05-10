
#nullable enable

namespace V0
{
    /// <summary>
    /// Basic metadata about a file, such as its type and name.
    /// </summary>
    public sealed partial class FileSummary
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSummary" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the file, including its extension.
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSummary(
            string name,
            string @object = "file")
        {
            this.Object = @object;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSummary" /> class.
        /// </summary>
        public FileSummary()
        {
        }

        /// <summary>
        /// Creates a new <see cref="FileSummary"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static FileSummary FromName(string name)
        {
            return new FileSummary
            {
                Name = name,
            };
        }

    }
}