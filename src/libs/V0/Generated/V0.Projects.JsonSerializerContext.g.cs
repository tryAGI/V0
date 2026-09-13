
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.EnvironmentVariableDetailSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.EnvironmentVariableSummarySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailPrivacy), TypeInfoPropertyName = "ProjectDetailPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ProjectDetailChat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailChatPrivacy), TypeInfoPropertyName = "ProjectDetailChatPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailChatLatestVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailChatLatestVersionStatus), TypeInfoPropertyName = "ProjectDetailChatLatestVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectSummaryPrivacy), TypeInfoPropertyName = "ProjectSummaryPrivacy2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ProjectsCreateRequestEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsCreateRequestEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsCreateRequestPrivacy), TypeInfoPropertyName = "ProjectsCreateRequestPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsUpdateRequestPrivacy), TypeInfoPropertyName = "ProjectsUpdateRequestPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsAssignRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsCreateEnvVarsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsUpdateEnvVarsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsDeleteEnvVarsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsDeleteDeleteAllChats), TypeInfoPropertyName = "ProjectsDeleteDeleteAllChats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsFindEnvVarsDecrypted), TypeInfoPropertyName = "ProjectsFindEnvVarsDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsCreateEnvVarsDecrypted), TypeInfoPropertyName = "ProjectsCreateEnvVarsDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsUpdateEnvVarsDecrypted), TypeInfoPropertyName = "ProjectsUpdateEnvVarsDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsGetEnvVarDecrypted), TypeInfoPropertyName = "ProjectsGetEnvVarDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsFindResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ProjectSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsAssignResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsFindEnvVarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.EnvironmentVariableSummarySchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsCreateEnvVarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsUpdateEnvVarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsDeleteEnvVarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ProjectsDeleteEnvVarsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsDeleteEnvVarsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsGetEnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailPrivacy?), TypeInfoPropertyName = "NullableProjectDetailPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailChatPrivacy?), TypeInfoPropertyName = "NullableProjectDetailChatPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailChatLatestVersionStatus?), TypeInfoPropertyName = "NullableProjectDetailChatLatestVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectSummaryPrivacy?), TypeInfoPropertyName = "NullableProjectSummaryPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsCreateRequestPrivacy?), TypeInfoPropertyName = "NullableProjectsCreateRequestPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsUpdateRequestPrivacy?), TypeInfoPropertyName = "NullableProjectsUpdateRequestPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsDeleteDeleteAllChats?), TypeInfoPropertyName = "NullableProjectsDeleteDeleteAllChats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsFindEnvVarsDecrypted?), TypeInfoPropertyName = "NullableProjectsFindEnvVarsDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsCreateEnvVarsDecrypted?), TypeInfoPropertyName = "NullableProjectsCreateEnvVarsDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsUpdateEnvVarsDecrypted?), TypeInfoPropertyName = "NullableProjectsUpdateEnvVarsDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsGetEnvVarDecrypted?), TypeInfoPropertyName = "NullableProjectsGetEnvVarDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectDetailChat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectsCreateRequestEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.EnvironmentVariableSummarySchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectsDeleteEnvVarsResponseDataItem>))]
    internal sealed partial class ProjectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::V0.ProjectDetailPrivacy)

                    || typeToConvert == typeof(global::V0.ProjectDetailPrivacy?)

                    || typeToConvert == typeof(global::V0.ProjectDetailChatPrivacy)

                    || typeToConvert == typeof(global::V0.ProjectDetailChatPrivacy?)

                    || typeToConvert == typeof(global::V0.ProjectDetailChatLatestVersionStatus)

                    || typeToConvert == typeof(global::V0.ProjectDetailChatLatestVersionStatus?)

                    || typeToConvert == typeof(global::V0.ProjectSummaryPrivacy)

                    || typeToConvert == typeof(global::V0.ProjectSummaryPrivacy?)

                    || typeToConvert == typeof(global::V0.ProjectsCreateRequestPrivacy)

                    || typeToConvert == typeof(global::V0.ProjectsCreateRequestPrivacy?)

                    || typeToConvert == typeof(global::V0.ProjectsUpdateRequestPrivacy)

                    || typeToConvert == typeof(global::V0.ProjectsUpdateRequestPrivacy?)

                    || typeToConvert == typeof(global::V0.ProjectsDeleteDeleteAllChats)

                    || typeToConvert == typeof(global::V0.ProjectsDeleteDeleteAllChats?)

                    || typeToConvert == typeof(global::V0.ProjectsFindEnvVarsDecrypted)

                    || typeToConvert == typeof(global::V0.ProjectsFindEnvVarsDecrypted?)

                    || typeToConvert == typeof(global::V0.ProjectsCreateEnvVarsDecrypted)

                    || typeToConvert == typeof(global::V0.ProjectsCreateEnvVarsDecrypted?)

                    || typeToConvert == typeof(global::V0.ProjectsUpdateEnvVarsDecrypted)

                    || typeToConvert == typeof(global::V0.ProjectsUpdateEnvVarsDecrypted?)

                    || typeToConvert == typeof(global::V0.ProjectsGetEnvVarDecrypted)

                    || typeToConvert == typeof(global::V0.ProjectsGetEnvVarDecrypted?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::V0.ProjectDetailPrivacy))
                {
                    return new global::V0.JsonConverters.ProjectDetailPrivacyJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectDetailPrivacy?))
                {
                    return new global::V0.JsonConverters.ProjectDetailPrivacyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectDetailChatPrivacy))
                {
                    return new global::V0.JsonConverters.ProjectDetailChatPrivacyJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectDetailChatPrivacy?))
                {
                    return new global::V0.JsonConverters.ProjectDetailChatPrivacyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectDetailChatLatestVersionStatus))
                {
                    return new global::V0.JsonConverters.ProjectDetailChatLatestVersionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectDetailChatLatestVersionStatus?))
                {
                    return new global::V0.JsonConverters.ProjectDetailChatLatestVersionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectSummaryPrivacy))
                {
                    return new global::V0.JsonConverters.ProjectSummaryPrivacyJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectSummaryPrivacy?))
                {
                    return new global::V0.JsonConverters.ProjectSummaryPrivacyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsCreateRequestPrivacy))
                {
                    return new global::V0.JsonConverters.ProjectsCreateRequestPrivacyJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsCreateRequestPrivacy?))
                {
                    return new global::V0.JsonConverters.ProjectsCreateRequestPrivacyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsUpdateRequestPrivacy))
                {
                    return new global::V0.JsonConverters.ProjectsUpdateRequestPrivacyJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsUpdateRequestPrivacy?))
                {
                    return new global::V0.JsonConverters.ProjectsUpdateRequestPrivacyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsDeleteDeleteAllChats))
                {
                    return new global::V0.JsonConverters.ProjectsDeleteDeleteAllChatsJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsDeleteDeleteAllChats?))
                {
                    return new global::V0.JsonConverters.ProjectsDeleteDeleteAllChatsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsFindEnvVarsDecrypted))
                {
                    return new global::V0.JsonConverters.ProjectsFindEnvVarsDecryptedJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsFindEnvVarsDecrypted?))
                {
                    return new global::V0.JsonConverters.ProjectsFindEnvVarsDecryptedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsCreateEnvVarsDecrypted))
                {
                    return new global::V0.JsonConverters.ProjectsCreateEnvVarsDecryptedJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsCreateEnvVarsDecrypted?))
                {
                    return new global::V0.JsonConverters.ProjectsCreateEnvVarsDecryptedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsUpdateEnvVarsDecrypted))
                {
                    return new global::V0.JsonConverters.ProjectsUpdateEnvVarsDecryptedJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsUpdateEnvVarsDecrypted?))
                {
                    return new global::V0.JsonConverters.ProjectsUpdateEnvVarsDecryptedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsGetEnvVarDecrypted))
                {
                    return new global::V0.JsonConverters.ProjectsGetEnvVarDecryptedJsonConverter();
                }

                if (typeToConvert == typeof(global::V0.ProjectsGetEnvVarDecrypted?))
                {
                    return new global::V0.JsonConverters.ProjectsGetEnvVarDecryptedNullableJsonConverter();
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
                    0 => new ProjectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}