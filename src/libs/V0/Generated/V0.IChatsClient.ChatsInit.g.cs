#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Initialize Chat<br/>
        /// Initializes a new chat from source content such as files, repositories, registries, or zip archives. Enables context-rich conversations based on code or assets.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsInitAsync(

            global::V0.AllOf<global::V0.ChatsInitRequest2, global::V0.AnyOf<global::V0.ChatsInitRequestVariant1, global::V0.ChatsInitRequestVariant22, global::V0.ChatsInitRequestVariant3, global::V0.ChatsInitRequestVariant4, global::V0.ChatsInitRequestVariant5>?> request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initialize Chat<br/>
        /// Initializes a new chat from source content such as files, repositories, registries, or zip archives. Enables context-rich conversations based on code or assets.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ChatDetail>> ChatsInitAsResponseAsync(

            global::V0.AllOf<global::V0.ChatsInitRequest2, global::V0.AnyOf<global::V0.ChatsInitRequestVariant1, global::V0.ChatsInitRequestVariant22, global::V0.ChatsInitRequestVariant3, global::V0.ChatsInitRequestVariant4, global::V0.ChatsInitRequestVariant5>?> request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initialize Chat<br/>
        /// Initializes a new chat from source content such as files, repositories, registries, or zip archives. Enables context-rich conversations based on code or assets.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsInitAsync(
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}