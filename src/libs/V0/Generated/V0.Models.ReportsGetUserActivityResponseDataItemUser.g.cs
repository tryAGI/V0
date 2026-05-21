
#nullable enable

namespace V0
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportsGetUserActivityResponseDataItemUser
    {
        /// <summary>
        /// A unique identifier for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fixed value identifying this object as a user.
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "user";

        /// <summary>
        /// Optional full name of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// URL to the user's avatar image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Avatar { get; set; }

        /// <summary>
        /// The ISO timestamp representing when the user was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ISO timestamp of the last update to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The user's v0 role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamV0Role")]
        public global::V0.ReportsGetUserActivityResponseDataItemUserTeamV0Role2? TeamV0Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUserActivityResponseDataItemUser" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the user.
        /// </param>
        /// <param name="email">
        /// The user's email address.
        /// </param>
        /// <param name="avatar">
        /// URL to the user's avatar image.
        /// </param>
        /// <param name="createdAt">
        /// The ISO timestamp representing when the user was created.
        /// </param>
        /// <param name="name">
        /// Optional full name of the user.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO timestamp of the last update to the user.
        /// </param>
        /// <param name="teamV0Role">
        /// The user's v0 role
        /// </param>
        /// <param name="object">
        /// Fixed value identifying this object as a user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportsGetUserActivityResponseDataItemUser(
            string id,
            string email,
            string avatar,
            global::System.DateTime createdAt,
            string? name,
            global::System.DateTime? updatedAt,
            global::V0.ReportsGetUserActivityResponseDataItemUserTeamV0Role2? teamV0Role,
            string @object = "user")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Avatar = avatar ?? throw new global::System.ArgumentNullException(nameof(avatar));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TeamV0Role = teamV0Role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsGetUserActivityResponseDataItemUser" /> class.
        /// </summary>
        public ReportsGetUserActivityResponseDataItemUser()
        {
        }

    }
}