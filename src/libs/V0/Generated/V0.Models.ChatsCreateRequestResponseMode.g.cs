
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
    public enum ChatsCreateRequestResponseMode
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
    public static class ChatsCreateRequestResponseModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatsCreateRequestResponseMode value)
        {
            return value switch
            {
                ChatsCreateRequestResponseMode.Async => "async",
                ChatsCreateRequestResponseMode.ExperimentalStream => "experimental_stream",
                ChatsCreateRequestResponseMode.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatsCreateRequestResponseMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => ChatsCreateRequestResponseMode.Async,
                "experimental_stream" => ChatsCreateRequestResponseMode.ExperimentalStream,
                "sync" => ChatsCreateRequestResponseMode.Sync,
                _ => null,
            };
        }
    }
}