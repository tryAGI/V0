
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatsInitRequestVariant1FileVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Whether to lock this file to prevent AI from overwriting it during generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        public bool? Locked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant1FileVariant1" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="locked">
        /// Whether to lock this file to prevent AI from overwriting it during generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatsInitRequestVariant1FileVariant1(
            string name,
            string url,
            bool? locked)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Locked = locked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsInitRequestVariant1FileVariant1" /> class.
        /// </summary>
        public ChatsInitRequestVariant1FileVariant1()
        {
        }
    }
}