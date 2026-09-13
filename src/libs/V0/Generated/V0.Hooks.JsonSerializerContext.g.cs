
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HookDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.HookDetailEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HookDetailEvent), TypeInfoPropertyName = "HookDetailEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HookSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UnauthorizedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UnauthorizedErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ForbiddenErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.NotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.NotFoundErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ConflictErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.PayloadTooLargeError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.PayloadTooLargeErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UnprocessableEntityError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UnprocessableEntityErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.TooManyRequestsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.TooManyRequestsErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.InternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.InternalServerErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.HooksCreateRequestEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksCreateRequestEvent), TypeInfoPropertyName = "HooksCreateRequestEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.HooksUpdateRequestEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksUpdateRequestEvent), TypeInfoPropertyName = "HooksUpdateRequestEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksFindResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.HookSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HookDetailEvent?), TypeInfoPropertyName = "NullableHookDetailEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksCreateRequestEvent?), TypeInfoPropertyName = "NullableHooksCreateRequestEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksUpdateRequestEvent?), TypeInfoPropertyName = "NullableHooksUpdateRequestEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.HookDetailEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.HooksCreateRequestEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.HooksUpdateRequestEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.HookSummary>))]
    internal sealed partial class HooksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HooksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static HooksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private HooksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::V0.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::V0.HookDetailEvent)

                    || typeToConvert == typeof(global::V0.HookDetailEvent?)

                    || typeToConvert == typeof(global::V0.HooksCreateRequestEvent)

                    || typeToConvert == typeof(global::V0.HooksCreateRequestEvent?)

                    || typeToConvert == typeof(global::V0.HooksUpdateRequestEvent)

                    || typeToConvert == typeof(global::V0.HooksUpdateRequestEvent?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::V0.HookDetailEvent))
                {
                    return new global::V0.JsonConverters.HookDetailEventJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.HookDetailEvent?))
                {
                    return new global::V0.JsonConverters.HookDetailEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.HooksCreateRequestEvent))
                {
                    return new global::V0.JsonConverters.HooksCreateRequestEventJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.HooksCreateRequestEvent?))
                {
                    return new global::V0.JsonConverters.HooksCreateRequestEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.HooksUpdateRequestEvent))
                {
                    return new global::V0.JsonConverters.HooksUpdateRequestEventJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.HooksUpdateRequestEvent?))
                {
                    return new global::V0.JsonConverters.HooksUpdateRequestEventNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new HooksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}