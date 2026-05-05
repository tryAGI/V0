#nullable enable

namespace V0
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Resolve Task<br/>
        /// Resolves a pending task in a chat, continuing the conversation. The latest message in the active chat fork must be an assistant message currently blocked on a matching task (integration setup, plan approval, question answers, or permission grants).
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsResolveTaskAsync(
            string chatId,

            global::V0.ChatsResolveTaskRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve Task<br/>
        /// Resolves a pending task in a chat, continuing the conversation. The latest message in the active chat fork must be an assistant message currently blocked on a matching task (integration setup, plan approval, question answers, or permission grants).
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::V0.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::V0.AutoSDKHttpResponse<global::V0.ChatDetail>> ChatsResolveTaskAsResponseAsync(
            string chatId,

            global::V0.ChatsResolveTaskRequest request,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve Task<br/>
        /// Resolves a pending task in a chat, continuing the conversation. The latest message in the active chat fork must be an assistant message currently blocked on a matching task (integration setup, plan approval, question answers, or permission grants).
        /// </summary>
        /// <param name="chatId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::V0.ChatDetail> ChatsResolveTaskAsync(
            string chatId,
            global::V0.AnyOf<global::V0.ChatsResolveTaskRequestTaskVariant1, global::V0.ChatsResolveTaskRequestTaskVariant2, global::V0.ChatsResolveTaskRequestTaskVariant3, global::V0.ChatsResolveTaskRequestTaskVariant4> task,
            global::V0.ChatsResolveTaskRequestResponseMode? responseMode = default,
            global::V0.ChatsResolveTaskRequestModelConfiguration? modelConfiguration = default,
            global::V0.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}