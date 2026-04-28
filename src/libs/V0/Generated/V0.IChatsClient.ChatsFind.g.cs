#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Find Chats<br/>
        /// Retrieves a list of existing chats, with support for pagination and filtering by favorite status, Vercel project, or Git branch. Helps manage and navigate chat history.
        /// </summary>
        /// <param name="limit">
        /// Specifies the maximum number of chat records to return in a single response. Useful for paginating results when there are many chats.<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="offset">
        /// Determines the starting point for pagination. Used in conjunction with limit to retrieve a specific page of chat results.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="isFavorite">
        /// Filters chats by their "favorite" status. Accepts `"true"` or `"false"` (as strings, not booleans).<br/>
        /// - `"true"`: returns only chats marked as favorites.<br/>
        /// - `"false"`: returns only non-favorite chats.
        /// </param>
        /// <param name="vercelProjectId">
        /// Filters chats by the linked Vercel project ID. Only returns chats associated with the specified Vercel project.
        /// </param>
        /// <param name="branch">
        /// Filters chats by the Git branch name. Only returns chats that have an active Git connection with the specified branch as the head.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatsFindResponse> ChatsFindAsync(
            double? limit = default,
            double? offset = default,
            global::V0.ChatsFindIsFavorite? isFavorite = default,
            string? vercelProjectId = default,
            string? branch = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}