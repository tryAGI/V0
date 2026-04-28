
#nullable enable

namespace V0
{
    /// <summary>
    /// Controls how the response is delivered.<br/>
    /// - `"sync"`: The response is returned immediately with the HTTP request.<br/>
    /// - `"async"`: Returns a message placeholder immediately; use getById to poll for completion status and final output.<br/>
    /// - `"experimental_stream"`: Returns content parts as Server-Sent Events for real-time streaming.<br/>
    /// Default Value: sync
    /// </summary>
    public enum ChatsResolveTaskRequestResponseMode
    {
        /// <summary>
        /// Returns a message placeholder immediately; use getById to poll for completion status and final output.
        /// </summary>
        Async,
        /// <summary>
        /// Returns content parts as Server-Sent Events for real-time streaming.
        /// </summary>
        ExperimentalStream,
        /// <summary>
        /// The response is returned immediately with the HTTP request.
        /// </summary>
        Sync,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatsResolveTaskRequestResponseModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsResolveTaskRequestResponseMode value)
        {
            return value switch
            {
                ChatsResolveTaskRequestResponseMode.Async => "async",
                ChatsResolveTaskRequestResponseMode.ExperimentalStream => "experimental_stream",
                ChatsResolveTaskRequestResponseMode.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsResolveTaskRequestResponseMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => ChatsResolveTaskRequestResponseMode.Async,
                "experimental_stream" => ChatsResolveTaskRequestResponseMode.ExperimentalStream,
                "sync" => ChatsResolveTaskRequestResponseMode.Sync,
                _ => null,
            };
        }
    }
}