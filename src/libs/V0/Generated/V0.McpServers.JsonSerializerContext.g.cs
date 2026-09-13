
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.McpServersCreateRequestAuthVariant1, global::V0.McpServersCreateRequestAuthVariant2, global::V0.McpServersCreateRequestAuthVariant3, global::V0.McpServersCreateRequestAuthVariant4>), TypeInfoPropertyName = "McpServersCreateRequestAuthVariant4_990bc977b5a8b8e5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.McpServersUpdateRequestAuthVariant1, global::V0.McpServersUpdateRequestAuthVariant2, global::V0.McpServersUpdateRequestAuthVariant3, global::V0.McpServersUpdateRequestAuthVariant4>), TypeInfoPropertyName = "McpServersUpdateRequestAuthVariant4_5b3d5ee955ccb658")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.McpServersCreateRequestAuthVariant1, global::V0.McpServersCreateRequestAuthVariant2, global::V0.McpServersCreateRequestAuthVariant3, global::V0.McpServersCreateRequestAuthVariant4>?), TypeInfoPropertyName = "McpServersCreateRequestAuthVariant4_8f63dc24968d8440")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.McpServersUpdateRequestAuthVariant1, global::V0.McpServersUpdateRequestAuthVariant2, global::V0.McpServersUpdateRequestAuthVariant3, global::V0.McpServersUpdateRequestAuthVariant4>?), TypeInfoPropertyName = "McpServersUpdateRequestAuthVariant4_cf08077114de3796")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestAuthVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestAuthVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestAuthVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestAuthVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestAuthVariant4Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestScope), TypeInfoPropertyName = "McpServersCreateRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestAuthVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestAuthVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestAuthVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestAuthVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestAuthVariant4Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestScope), TypeInfoPropertyName = "McpServersUpdateRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateOAuthAuthorizationUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersFindResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.McpServersFindResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersFindResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersFindResponseDataItemAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersFindResponseDataItemAuthType), TypeInfoPropertyName = "McpServersFindResponseDataItemAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersFindResponseDataItemScope), TypeInfoPropertyName = "McpServersFindResponseDataItemScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateResponseAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateResponseAuthType), TypeInfoPropertyName = "McpServersCreateResponseAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateResponseScope), TypeInfoPropertyName = "McpServersCreateResponseScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersGetByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersGetByIdResponseAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersGetByIdResponseAuthType), TypeInfoPropertyName = "McpServersGetByIdResponseAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersGetByIdResponseScope), TypeInfoPropertyName = "McpServersGetByIdResponseScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateResponseAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateResponseAuthType), TypeInfoPropertyName = "McpServersUpdateResponseAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateResponseScope), TypeInfoPropertyName = "McpServersUpdateResponseScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateOAuthAuthorizationUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestScope?), TypeInfoPropertyName = "NullableMcpServersCreateRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestScope?), TypeInfoPropertyName = "NullableMcpServersUpdateRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersFindResponseDataItemAuthType?), TypeInfoPropertyName = "NullableMcpServersFindResponseDataItemAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersFindResponseDataItemScope?), TypeInfoPropertyName = "NullableMcpServersFindResponseDataItemScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateResponseAuthType?), TypeInfoPropertyName = "NullableMcpServersCreateResponseAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateResponseScope?), TypeInfoPropertyName = "NullableMcpServersCreateResponseScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersGetByIdResponseAuthType?), TypeInfoPropertyName = "NullableMcpServersGetByIdResponseAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersGetByIdResponseScope?), TypeInfoPropertyName = "NullableMcpServersGetByIdResponseScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateResponseAuthType?), TypeInfoPropertyName = "NullableMcpServersUpdateResponseAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateResponseScope?), TypeInfoPropertyName = "NullableMcpServersUpdateResponseScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.McpServersFindResponseDataItem>))]
    internal sealed partial class McpServersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class McpServersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static McpServersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private McpServersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::V0.JsonConverters.AnyOfJsonConverter<global::V0.McpServersCreateRequestAuthVariant1, global::V0.McpServersCreateRequestAuthVariant2, global::V0.McpServersCreateRequestAuthVariant3, global::V0.McpServersCreateRequestAuthVariant4>());
            options.Converters.Add(new global::V0.JsonConverters.AnyOfJsonConverter<global::V0.McpServersUpdateRequestAuthVariant1, global::V0.McpServersUpdateRequestAuthVariant2, global::V0.McpServersUpdateRequestAuthVariant3, global::V0.McpServersUpdateRequestAuthVariant4>());
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
                    typeToConvert == typeof(global::V0.McpServersCreateRequestScope)

                    || typeToConvert == typeof(global::V0.McpServersCreateRequestScope?)

                    || typeToConvert == typeof(global::V0.McpServersUpdateRequestScope)

                    || typeToConvert == typeof(global::V0.McpServersUpdateRequestScope?)

                    || typeToConvert == typeof(global::V0.McpServersFindResponseDataItemAuthType)

                    || typeToConvert == typeof(global::V0.McpServersFindResponseDataItemAuthType?)

                    || typeToConvert == typeof(global::V0.McpServersFindResponseDataItemScope)

                    || typeToConvert == typeof(global::V0.McpServersFindResponseDataItemScope?)

                    || typeToConvert == typeof(global::V0.McpServersCreateResponseAuthType)

                    || typeToConvert == typeof(global::V0.McpServersCreateResponseAuthType?)

                    || typeToConvert == typeof(global::V0.McpServersCreateResponseScope)

                    || typeToConvert == typeof(global::V0.McpServersCreateResponseScope?)

                    || typeToConvert == typeof(global::V0.McpServersGetByIdResponseAuthType)

                    || typeToConvert == typeof(global::V0.McpServersGetByIdResponseAuthType?)

                    || typeToConvert == typeof(global::V0.McpServersGetByIdResponseScope)

                    || typeToConvert == typeof(global::V0.McpServersGetByIdResponseScope?)

                    || typeToConvert == typeof(global::V0.McpServersUpdateResponseAuthType)

                    || typeToConvert == typeof(global::V0.McpServersUpdateResponseAuthType?)

                    || typeToConvert == typeof(global::V0.McpServersUpdateResponseScope)

                    || typeToConvert == typeof(global::V0.McpServersUpdateResponseScope?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::V0.McpServersCreateRequestScope))
                {
                    return new global::V0.JsonConverters.McpServersCreateRequestScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersCreateRequestScope?))
                {
                    return new global::V0.JsonConverters.McpServersCreateRequestScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersUpdateRequestScope))
                {
                    return new global::V0.JsonConverters.McpServersUpdateRequestScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersUpdateRequestScope?))
                {
                    return new global::V0.JsonConverters.McpServersUpdateRequestScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersFindResponseDataItemAuthType))
                {
                    return new global::V0.JsonConverters.McpServersFindResponseDataItemAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersFindResponseDataItemAuthType?))
                {
                    return new global::V0.JsonConverters.McpServersFindResponseDataItemAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersFindResponseDataItemScope))
                {
                    return new global::V0.JsonConverters.McpServersFindResponseDataItemScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersFindResponseDataItemScope?))
                {
                    return new global::V0.JsonConverters.McpServersFindResponseDataItemScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersCreateResponseAuthType))
                {
                    return new global::V0.JsonConverters.McpServersCreateResponseAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersCreateResponseAuthType?))
                {
                    return new global::V0.JsonConverters.McpServersCreateResponseAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersCreateResponseScope))
                {
                    return new global::V0.JsonConverters.McpServersCreateResponseScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersCreateResponseScope?))
                {
                    return new global::V0.JsonConverters.McpServersCreateResponseScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersGetByIdResponseAuthType))
                {
                    return new global::V0.JsonConverters.McpServersGetByIdResponseAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersGetByIdResponseAuthType?))
                {
                    return new global::V0.JsonConverters.McpServersGetByIdResponseAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersGetByIdResponseScope))
                {
                    return new global::V0.JsonConverters.McpServersGetByIdResponseScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersGetByIdResponseScope?))
                {
                    return new global::V0.JsonConverters.McpServersGetByIdResponseScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersUpdateResponseAuthType))
                {
                    return new global::V0.JsonConverters.McpServersUpdateResponseAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersUpdateResponseAuthType?))
                {
                    return new global::V0.JsonConverters.McpServersUpdateResponseAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersUpdateResponseScope))
                {
                    return new global::V0.JsonConverters.McpServersUpdateResponseScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.McpServersUpdateResponseScope?))
                {
                    return new global::V0.JsonConverters.McpServersUpdateResponseScopeNullableJsonConverter();
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
                    0 => new McpServersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}