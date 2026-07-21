
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
            typeof(global::V0.JsonConverters.ChatDetailPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailLatestVersionStatusJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailLatestVersionStatusNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailMessageTypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailMessageTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailMessageRoleJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailMessageRoleNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailMessageFinishReasonJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailMessageFinishReasonNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailMessageAttachmentTypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailMessageAttachmentTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailModelConfigurationModelIdJsonConverter),

            typeof(global::V0.JsonConverters.ChatDetailModelConfigurationModelIdNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatSummaryPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ChatSummaryPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatSummaryLatestVersionStatusJsonConverter),

            typeof(global::V0.JsonConverters.ChatSummaryLatestVersionStatusNullableJsonConverter),

            typeof(global::V0.JsonConverters.HookDetailEventJsonConverter),

            typeof(global::V0.JsonConverters.HookDetailEventNullableJsonConverter),

            typeof(global::V0.JsonConverters.HookEventDetailEventJsonConverter),

            typeof(global::V0.JsonConverters.HookEventDetailEventNullableJsonConverter),

            typeof(global::V0.JsonConverters.HookEventDetailStatusJsonConverter),

            typeof(global::V0.JsonConverters.HookEventDetailStatusNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageDetailTypeJsonConverter),

            typeof(global::V0.JsonConverters.MessageDetailTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageDetailRoleJsonConverter),

            typeof(global::V0.JsonConverters.MessageDetailRoleNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageDetailFinishReasonJsonConverter),

            typeof(global::V0.JsonConverters.MessageDetailFinishReasonNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageDetailAttachmentTypeJsonConverter),

            typeof(global::V0.JsonConverters.MessageDetailAttachmentTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryTypeJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryRoleJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryRoleNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryFinishReasonJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryFinishReasonNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryAttachmentTypeJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryAttachmentTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryListDataItemTypeJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryListDataItemTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryListDataItemRoleJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryListDataItemRoleNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryListDataItemFinishReasonJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryListDataItemFinishReasonNullableJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryListDataItemAttachmentTypeJsonConverter),

            typeof(global::V0.JsonConverters.MessageSummaryListDataItemAttachmentTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProductDetailSchemaV0AvailabilityJsonConverter),

            typeof(global::V0.JsonConverters.ProductDetailSchemaV0AvailabilityNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProductListSchemaDataItemV0AvailabilityJsonConverter),

            typeof(global::V0.JsonConverters.ProductListSchemaDataItemV0AvailabilityNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProductSummarySchemaV0AvailabilityJsonConverter),

            typeof(global::V0.JsonConverters.ProductSummarySchemaV0AvailabilityNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectDetailPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ProjectDetailPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectDetailChatPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ProjectDetailChatPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectDetailChatLatestVersionStatusJsonConverter),

            typeof(global::V0.JsonConverters.ProjectDetailChatLatestVersionStatusNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectSummaryPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ProjectSummaryPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.SearchResultItemObjectJsonConverter),

            typeof(global::V0.JsonConverters.SearchResultItemObjectNullableJsonConverter),

            typeof(global::V0.JsonConverters.VersionDetailStatusJsonConverter),

            typeof(global::V0.JsonConverters.VersionDetailStatusNullableJsonConverter),

            typeof(global::V0.JsonConverters.VersionSummaryStatusJsonConverter),

            typeof(global::V0.JsonConverters.VersionSummaryStatusNullableJsonConverter),

            typeof(global::V0.JsonConverters.VersionSummaryListDataItemStatusJsonConverter),

            typeof(global::V0.JsonConverters.VersionSummaryListDataItemStatusNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestChatPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestChatPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestModelConfigurationModelIdJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestModelConfigurationModelIdNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestResponseModeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestResponseModeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestSkillVariant1TypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestSkillVariant1TypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestSkillVariant2TypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestSkillVariant2TypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestSkillVariant2ScopeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestSkillVariant2ScopeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestSkillVariant3TypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsCreateRequestSkillVariant3TypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsInitRequestChatPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ChatsInitRequestChatPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsUpdateRequestPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ChatsUpdateRequestPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsForkRequestPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ChatsForkRequestPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestModelConfigurationModelIdJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestModelConfigurationModelIdNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestResponseModeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestResponseModeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestSkillVariant1TypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestSkillVariant1TypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestSkillVariant2TypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestSkillVariant2TypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestSkillVariant2ScopeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestSkillVariant2ScopeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestSkillVariant3TypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsSendMessageRequestSkillVariant3TypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant1TypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant1TypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetNameJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetNameNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant2TypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant2TypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant2StatusJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant2StatusNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant3TypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant3TypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant4TypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant4TypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant4PermissionTypeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestTaskVariant4PermissionTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestResponseModeJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestResponseModeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestModelConfigurationModelIdJsonConverter),

            typeof(global::V0.JsonConverters.ChatsResolveTaskRequestModelConfigurationModelIdNullableJsonConverter),

            typeof(global::V0.JsonConverters.HooksCreateRequestEventJsonConverter),

            typeof(global::V0.JsonConverters.HooksCreateRequestEventNullableJsonConverter),

            typeof(global::V0.JsonConverters.HooksUpdateRequestEventJsonConverter),

            typeof(global::V0.JsonConverters.HooksUpdateRequestEventNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsCreateRequestPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsCreateRequestPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsUpdateRequestPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsUpdateRequestPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.McpServersCreateRequestScopeJsonConverter),

            typeof(global::V0.JsonConverters.McpServersCreateRequestScopeNullableJsonConverter),

            typeof(global::V0.JsonConverters.McpServersUpdateRequestScopeJsonConverter),

            typeof(global::V0.JsonConverters.McpServersUpdateRequestScopeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsFindIsFavoriteJsonConverter),

            typeof(global::V0.JsonConverters.ChatsFindIsFavoriteNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsGetVersionIncludeDefaultFilesJsonConverter),

            typeof(global::V0.JsonConverters.ChatsGetVersionIncludeDefaultFilesNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsDownloadVersionFormatJsonConverter),

            typeof(global::V0.JsonConverters.ChatsDownloadVersionFormatNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsDownloadVersionIncludeDefaultFilesJsonConverter),

            typeof(global::V0.JsonConverters.ChatsDownloadVersionIncludeDefaultFilesNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsDeleteDeleteAllChatsJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsDeleteDeleteAllChatsNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsFindEnvVarsDecryptedJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsFindEnvVarsDecryptedNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsCreateEnvVarsDecryptedJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsCreateEnvVarsDecryptedNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsUpdateEnvVarsDecryptedJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsUpdateEnvVarsDecryptedNullableJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsGetEnvVarDecryptedJsonConverter),

            typeof(global::V0.JsonConverters.ProjectsGetEnvVarDecryptedNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsFindResponseDataItemPrivacyJsonConverter),

            typeof(global::V0.JsonConverters.ChatsFindResponseDataItemPrivacyNullableJsonConverter),

            typeof(global::V0.JsonConverters.ChatsFindResponseDataItemLatestVersionStatusJsonConverter),

            typeof(global::V0.JsonConverters.ChatsFindResponseDataItemLatestVersionStatusNullableJsonConverter),

            typeof(global::V0.JsonConverters.DeploymentsFindLogsResponseLogTypeJsonConverter),

            typeof(global::V0.JsonConverters.DeploymentsFindLogsResponseLogTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.DeploymentsFindLogsResponseLogLevelJsonConverter),

            typeof(global::V0.JsonConverters.DeploymentsFindLogsResponseLogLevelNullableJsonConverter),

            typeof(global::V0.JsonConverters.ReportsGetUsageResponseDataItemTypeJsonConverter),

            typeof(global::V0.JsonConverters.ReportsGetUsageResponseDataItemTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.ReportsGetUserActivityResponseDataItemUserTeamV0Role2JsonConverter),

            typeof(global::V0.JsonConverters.ReportsGetUserActivityResponseDataItemUserTeamV0Role2NullableJsonConverter),

            typeof(global::V0.JsonConverters.McpServersFindResponseDataItemAuthTypeJsonConverter),

            typeof(global::V0.JsonConverters.McpServersFindResponseDataItemAuthTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.McpServersFindResponseDataItemScopeJsonConverter),

            typeof(global::V0.JsonConverters.McpServersFindResponseDataItemScopeNullableJsonConverter),

            typeof(global::V0.JsonConverters.McpServersCreateResponseAuthTypeJsonConverter),

            typeof(global::V0.JsonConverters.McpServersCreateResponseAuthTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.McpServersCreateResponseScopeJsonConverter),

            typeof(global::V0.JsonConverters.McpServersCreateResponseScopeNullableJsonConverter),

            typeof(global::V0.JsonConverters.McpServersGetByIdResponseAuthTypeJsonConverter),

            typeof(global::V0.JsonConverters.McpServersGetByIdResponseAuthTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.McpServersGetByIdResponseScopeJsonConverter),

            typeof(global::V0.JsonConverters.McpServersGetByIdResponseScopeNullableJsonConverter),

            typeof(global::V0.JsonConverters.McpServersUpdateResponseAuthTypeJsonConverter),

            typeof(global::V0.JsonConverters.McpServersUpdateResponseAuthTypeNullableJsonConverter),

            typeof(global::V0.JsonConverters.McpServersUpdateResponseScopeJsonConverter),

            typeof(global::V0.JsonConverters.McpServersUpdateResponseScopeNullableJsonConverter),

            typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>),

            typeof(global::V0.JsonConverters.AllOfJsonConverter<global::V0.ChatsInitRequest2, global::V0.AnyOf<global::V0.ChatsInitRequestVariant1, global::V0.ChatsInitRequestVariant22, global::V0.ChatsInitRequestVariant3, global::V0.ChatsInitRequestVariant4, global::V0.ChatsInitRequestVariant5>?>),

            typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.ChatsInitRequestVariant1, global::V0.ChatsInitRequestVariant22, global::V0.ChatsInitRequestVariant3, global::V0.ChatsInitRequestVariant4, global::V0.ChatsInitRequestVariant5>),

            typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>),

            typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.ChatsSendMessageRequestSkillVariant1, global::V0.ChatsSendMessageRequestSkillVariant2, global::V0.ChatsSendMessageRequestSkillVariant3>),

            typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.ChatsResolveTaskRequestTaskVariant1, global::V0.ChatsResolveTaskRequestTaskVariant2, global::V0.ChatsResolveTaskRequestTaskVariant3, global::V0.ChatsResolveTaskRequestTaskVariant4>),

            typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.McpServersCreateRequestAuthVariant1, global::V0.McpServersCreateRequestAuthVariant2, global::V0.McpServersCreateRequestAuthVariant3, global::V0.McpServersCreateRequestAuthVariant4>),

            typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.McpServersUpdateRequestAuthVariant1, global::V0.McpServersUpdateRequestAuthVariant2, global::V0.McpServersUpdateRequestAuthVariant3, global::V0.McpServersUpdateRequestAuthVariant4>),

            typeof(global::V0.JsonConverters.AnyOfJsonConverter<global::V0.UserGetBillingResponseVariant1, global::V0.UserGetBillingResponseVariant2>),

            typeof(global::V0.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailPrivacy), TypeInfoPropertyName = "ChatDetailPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailLatestVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailLatestVersionStatus), TypeInfoPropertyName = "ChatDetailLatestVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatDetailLatestVersionFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailLatestVersionFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatDetailMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailMessageType), TypeInfoPropertyName = "ChatDetailMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailMessageRole), TypeInfoPropertyName = "ChatDetailMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailMessageFinishReason), TypeInfoPropertyName = "ChatDetailMessageFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatDetailMessageAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailMessageAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailMessageAttachmentType), TypeInfoPropertyName = "ChatDetailMessageAttachmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatDetailFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailModelConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailModelConfigurationModelId), TypeInfoPropertyName = "ChatDetailModelConfigurationModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatDetailPermissions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatSummaryPrivacy), TypeInfoPropertyName = "ChatSummaryPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatSummaryLatestVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatSummaryLatestVersionStatus), TypeInfoPropertyName = "ChatSummaryLatestVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.DeploymentDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.DeploymentSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.EnvironmentVariableDetailSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.EnvironmentVariableSummarySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.EnvironmentVariablesListSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.EnvironmentVariablesListSchemaDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.EnvironmentVariablesListSchemaDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.FileDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.FileSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HookDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.HookDetailEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HookDetailEvent), TypeInfoPropertyName = "HookDetailEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HookEventDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HookEventDetailEvent), TypeInfoPropertyName = "HookEventDetailEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HookEventDetailStatus), TypeInfoPropertyName = "HookEventDetailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HookSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationConnectionDetailSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationConnectionDetailSchemaIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationConnectionListSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.IntegrationConnectionListSchemaDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationConnectionListSchemaDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationConnectionListSchemaDataItemIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationConnectionSummarySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationConnectionSummarySchemaIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationDetailSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationListSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.IntegrationListSchemaDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationListSchemaDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationSummarySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageDetailType), TypeInfoPropertyName = "MessageDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageDetailRole), TypeInfoPropertyName = "MessageDetailRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageDetailFinishReason), TypeInfoPropertyName = "MessageDetailFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.MessageDetailAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageDetailAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageDetailAttachmentType), TypeInfoPropertyName = "MessageDetailAttachmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryType), TypeInfoPropertyName = "MessageSummaryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryRole), TypeInfoPropertyName = "MessageSummaryRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryFinishReason), TypeInfoPropertyName = "MessageSummaryFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.MessageSummaryAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryAttachmentType), TypeInfoPropertyName = "MessageSummaryAttachmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.MessageSummaryListDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryListDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryListDataItemType), TypeInfoPropertyName = "MessageSummaryListDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryListDataItemRole), TypeInfoPropertyName = "MessageSummaryListDataItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryListDataItemFinishReason), TypeInfoPropertyName = "MessageSummaryListDataItemFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.MessageSummaryListDataItemAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryListDataItemAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryListDataItemAttachmentType), TypeInfoPropertyName = "MessageSummaryListDataItemAttachmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.MessageSummaryListPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.NotificationPreferenceSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProductDetailSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProductDetailSchemaV0Availability), TypeInfoPropertyName = "ProductDetailSchemaV0Availability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProductListSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ProductListSchemaDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProductListSchemaDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProductListSchemaDataItemV0Availability), TypeInfoPropertyName = "ProductListSchemaDataItemV0Availability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProductSummarySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProductSummarySchemaV0Availability), TypeInfoPropertyName = "ProductSummarySchemaV0Availability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailPrivacy), TypeInfoPropertyName = "ProjectDetailPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ProjectDetailChat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailChatPrivacy), TypeInfoPropertyName = "ProjectDetailChatPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailChatLatestVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectDetailChatLatestVersionStatus), TypeInfoPropertyName = "ProjectDetailChatLatestVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectSummaryPrivacy), TypeInfoPropertyName = "ProjectSummaryPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ScopeSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.SearchResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.SearchResultItemObject), TypeInfoPropertyName = "SearchResultItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserDetailSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserPreferencesPostResponseSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserPreferencesPostResponseSchemaPreferences2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserPreferencesPostResponseSchemaPreferencesNotifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserPreferencesResponseSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserPreferencesResponseSchemaPreferences2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserPreferencesResponseSchemaPreferencesNotifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserPreferencesSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserPreferencesSchemaNotifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserSummarySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VercelProjectDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VercelProjectSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VersionDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VersionDetailStatus), TypeInfoPropertyName = "VersionDetailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.VersionDetailFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VersionDetailFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VersionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VersionSummaryStatus), TypeInfoPropertyName = "VersionSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VersionSummaryList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.VersionSummaryListDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VersionSummaryListDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VersionSummaryListDataItemStatus), TypeInfoPropertyName = "VersionSummaryListDataItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.VersionSummaryListPagination))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatsCreateRequestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestChatPrivacy), TypeInfoPropertyName = "ChatsCreateRequestChatPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestModelConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestModelConfigurationModelId), TypeInfoPropertyName = "ChatsCreateRequestModelConfigurationModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestResponseMode), TypeInfoPropertyName = "ChatsCreateRequestResponseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>), TypeInfoPropertyName = "AnyOfChatsCreateRequestSkillVariant1ChatsCreateRequestSkillVariant2ChatsCreateRequestSkillVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestSkillVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestSkillVariant1Type), TypeInfoPropertyName = "ChatsCreateRequestSkillVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestSkillVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestSkillVariant2Type), TypeInfoPropertyName = "ChatsCreateRequestSkillVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestSkillVariant2Scope), TypeInfoPropertyName = "ChatsCreateRequestSkillVariant2Scope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestSkillVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsCreateRequestSkillVariant3Type), TypeInfoPropertyName = "ChatsCreateRequestSkillVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AllOf<global::V0.ChatsInitRequest2, global::V0.AnyOf<global::V0.ChatsInitRequestVariant1, global::V0.ChatsInitRequestVariant22, global::V0.ChatsInitRequestVariant3, global::V0.ChatsInitRequestVariant4, global::V0.ChatsInitRequestVariant5>?>), TypeInfoPropertyName = "ChatsInitRequestVariant5_842f996a567a8178")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestChatPrivacy), TypeInfoPropertyName = "ChatsInitRequestChatPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.ChatsInitRequestVariant1, global::V0.ChatsInitRequestVariant22, global::V0.ChatsInitRequestVariant3, global::V0.ChatsInitRequestVariant4, global::V0.ChatsInitRequestVariant5>), TypeInfoPropertyName = "ChatsInitRequestVariant5_e3cc9d12fcbea52e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>), TypeInfoPropertyName = "AnyOfChatsInitRequestVariant1FileVariant1ChatsInitRequestVariant1FileVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestVariant1FileVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestVariant1FileVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestVariant2Repo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestVariant3Registry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestVariant4Zip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsInitRequestVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsUpdateRequestPrivacy), TypeInfoPropertyName = "ChatsUpdateRequestPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFavoriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsForkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsForkRequestPrivacy), TypeInfoPropertyName = "ChatsForkRequestPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatsSendMessageRequestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestModelConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestModelConfigurationModelId), TypeInfoPropertyName = "ChatsSendMessageRequestModelConfigurationModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestResponseMode), TypeInfoPropertyName = "ChatsSendMessageRequestResponseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsSendMessageRequestSkillVariant1, global::V0.ChatsSendMessageRequestSkillVariant2, global::V0.ChatsSendMessageRequestSkillVariant3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.ChatsSendMessageRequestSkillVariant1, global::V0.ChatsSendMessageRequestSkillVariant2, global::V0.ChatsSendMessageRequestSkillVariant3>), TypeInfoPropertyName = "AnyOfChatsSendMessageRequestSkillVariant1ChatsSendMessageRequestSkillVariant2ChatsSendMessageRequestSkillVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestSkillVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestSkillVariant1Type), TypeInfoPropertyName = "ChatsSendMessageRequestSkillVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestSkillVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestSkillVariant2Type), TypeInfoPropertyName = "ChatsSendMessageRequestSkillVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestSkillVariant2Scope), TypeInfoPropertyName = "ChatsSendMessageRequestSkillVariant2Scope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestSkillVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestSkillVariant3Type), TypeInfoPropertyName = "ChatsSendMessageRequestSkillVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsSendMessageRequestAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsUpdateVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatsUpdateVersionRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsUpdateVersionRequestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsDeleteVersionFilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.ChatsResolveTaskRequestTaskVariant1, global::V0.ChatsResolveTaskRequestTaskVariant2, global::V0.ChatsResolveTaskRequestTaskVariant3, global::V0.ChatsResolveTaskRequestTaskVariant4>), TypeInfoPropertyName = "ChatsResolveTaskRequestTaskVariant4_73f9598d350f9e84")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant1Type), TypeInfoPropertyName = "ChatsResolveTaskRequestTaskVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName), TypeInfoPropertyName = "ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant2Type), TypeInfoPropertyName = "ChatsResolveTaskRequestTaskVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant2Status), TypeInfoPropertyName = "ChatsResolveTaskRequestTaskVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant3Type), TypeInfoPropertyName = "ChatsResolveTaskRequestTaskVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant3Answer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant3Answer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant4Type), TypeInfoPropertyName = "ChatsResolveTaskRequestTaskVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant4Permission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant4Permission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestTaskVariant4PermissionType), TypeInfoPropertyName = "ChatsResolveTaskRequestTaskVariant4PermissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestResponseMode), TypeInfoPropertyName = "ChatsResolveTaskRequestResponseMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestModelConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsResolveTaskRequestModelConfigurationModelId), TypeInfoPropertyName = "ChatsResolveTaskRequestModelConfigurationModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.DeploymentsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.HooksCreateRequestEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksCreateRequestEvent), TypeInfoPropertyName = "HooksCreateRequestEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.HooksUpdateRequestEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksUpdateRequestEvent), TypeInfoPropertyName = "HooksUpdateRequestEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationsVercelProjectsCreateRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.McpServersCreateRequestAuthVariant1, global::V0.McpServersCreateRequestAuthVariant2, global::V0.McpServersCreateRequestAuthVariant3, global::V0.McpServersCreateRequestAuthVariant4>), TypeInfoPropertyName = "McpServersCreateRequestAuthVariant4_990bc977b5a8b8e5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestAuthVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestAuthVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestAuthVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestAuthVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestAuthVariant4Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateRequestScope), TypeInfoPropertyName = "McpServersCreateRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.McpServersUpdateRequestAuthVariant1, global::V0.McpServersUpdateRequestAuthVariant2, global::V0.McpServersUpdateRequestAuthVariant3, global::V0.McpServersUpdateRequestAuthVariant4>), TypeInfoPropertyName = "McpServersUpdateRequestAuthVariant4_5b3d5ee955ccb658")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestAuthVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestAuthVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestAuthVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestAuthVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestAuthVariant4Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersUpdateRequestScope), TypeInfoPropertyName = "McpServersUpdateRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.McpServersCreateOAuthAuthorizationUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindIsFavorite), TypeInfoPropertyName = "ChatsFindIsFavorite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsGetVersionIncludeDefaultFiles), TypeInfoPropertyName = "ChatsGetVersionIncludeDefaultFiles2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsDownloadVersionFormat), TypeInfoPropertyName = "ChatsDownloadVersionFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsDownloadVersionIncludeDefaultFiles), TypeInfoPropertyName = "ChatsDownloadVersionIncludeDefaultFiles2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsDeleteDeleteAllChats), TypeInfoPropertyName = "ProjectsDeleteDeleteAllChats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsFindEnvVarsDecrypted), TypeInfoPropertyName = "ProjectsFindEnvVarsDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsCreateEnvVarsDecrypted), TypeInfoPropertyName = "ProjectsCreateEnvVarsDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsUpdateEnvVarsDecrypted), TypeInfoPropertyName = "ProjectsUpdateEnvVarsDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ProjectsGetEnvVarDecrypted), TypeInfoPropertyName = "ProjectsGetEnvVarDecrypted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ChatsFindResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindResponseDataItemPrivacy), TypeInfoPropertyName = "ChatsFindResponseDataItemPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindResponseDataItemLatestVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindResponseDataItemLatestVersionStatus), TypeInfoPropertyName = "ChatsFindResponseDataItemLatestVersionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFavoriteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.MessageSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindMessagesResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.VersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindVersionsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsFindVersionsResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ChatsStopResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.DeploymentsFindResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.DeploymentDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.DeploymentsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.DeploymentsFindLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.DeploymentsFindLogsResponseLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.DeploymentsFindLogsResponseLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.DeploymentsFindLogsResponseLogType), TypeInfoPropertyName = "DeploymentsFindLogsResponseLogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.DeploymentsFindLogsResponseLogLevel), TypeInfoPropertyName = "DeploymentsFindLogsResponseLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.DeploymentsFindErrorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksFindResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.HookSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.HooksDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.IntegrationsVercelProjectsFindResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.VercelProjectSummary>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.RateLimitsFindResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.RateLimitsFindResponseDailyLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.UserGetBillingResponseVariant1, global::V0.UserGetBillingResponseVariant2>), TypeInfoPropertyName = "AnyOfUserGetBillingResponseVariant1UserGetBillingResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetBillingResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetBillingResponseVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetBillingResponseVariant1DataBillingCycle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetBillingResponseVariant1DataBalance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetBillingResponseVariant1DataOnDemand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.UserGetBillingResponseVariant1DataOnDemandBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetBillingResponseVariant1DataOnDemandBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetBillingResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetBillingResponseVariant2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetPlanResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetPlanResponseBillingCycle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetPlanResponseBalance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.UserGetScopesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ScopeSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ReportsGetUsageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUsageResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUsageResponseDataItemType), TypeInfoPropertyName = "ReportsGetUsageResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUsageResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUsageResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetAIUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ReportsGetAIUsageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetAIUsageResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetAIUsageResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetAIUsageResponseDateRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUserActivityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::V0.ReportsGetUserActivityResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUserActivityResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUserActivityResponseDataItemUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUserActivityResponseDataItemUserTeamV0Role2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUserActivityResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.ReportsGetUserActivityResponseMetaDateRange))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AllOf<global::V0.ChatsInitRequest2, global::V0.AnyOf<global::V0.ChatsInitRequestVariant1, global::V0.ChatsInitRequestVariant22, global::V0.ChatsInitRequestVariant3, global::V0.ChatsInitRequestVariant4, global::V0.ChatsInitRequestVariant5>?>?), TypeInfoPropertyName = "ChatsInitRequestVariant5_37d682f35fad2e9d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.ChatsInitRequestVariant1, global::V0.ChatsInitRequestVariant22, global::V0.ChatsInitRequestVariant3, global::V0.ChatsInitRequestVariant4, global::V0.ChatsInitRequestVariant5>?), TypeInfoPropertyName = "ChatsInitRequestVariant5_81f724b881d7ba5b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.ChatsSendMessageRequestSkillVariant1, global::V0.ChatsSendMessageRequestSkillVariant2, global::V0.ChatsSendMessageRequestSkillVariant3>?), TypeInfoPropertyName = "ChatsSendMessageRequestSkillVariant3_7388c3805f550d48")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.ChatsResolveTaskRequestTaskVariant1, global::V0.ChatsResolveTaskRequestTaskVariant2, global::V0.ChatsResolveTaskRequestTaskVariant3, global::V0.ChatsResolveTaskRequestTaskVariant4>?), TypeInfoPropertyName = "ChatsResolveTaskRequestTaskVariant4_a1ad15825c1305f0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.McpServersCreateRequestAuthVariant1, global::V0.McpServersCreateRequestAuthVariant2, global::V0.McpServersCreateRequestAuthVariant3, global::V0.McpServersCreateRequestAuthVariant4>?), TypeInfoPropertyName = "McpServersCreateRequestAuthVariant4_8f63dc24968d8440")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::V0.AnyOf<global::V0.McpServersUpdateRequestAuthVariant1, global::V0.McpServersUpdateRequestAuthVariant2, global::V0.McpServersUpdateRequestAuthVariant3, global::V0.McpServersUpdateRequestAuthVariant4>?), TypeInfoPropertyName = "McpServersUpdateRequestAuthVariant4_cf08077114de3796")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatDetailLatestVersionFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatDetailMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatDetailMessageAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatDetailFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.EnvironmentVariablesListSchemaDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.HookDetailEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.IntegrationConnectionListSchemaDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.IntegrationListSchemaDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.MessageDetailAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.MessageSummaryAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.MessageSummaryListDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.MessageSummaryListDataItemAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProductListSchemaDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectDetailChat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.VersionDetailFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.VersionSummaryListDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatsCreateRequestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatsSendMessageRequestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.AnyOf<global::V0.ChatsSendMessageRequestSkillVariant1, global::V0.ChatsSendMessageRequestSkillVariant2, global::V0.ChatsSendMessageRequestSkillVariant3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatsUpdateVersionRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatsResolveTaskRequestTaskVariant3Answer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatsResolveTaskRequestTaskVariant4Permission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.HooksCreateRequestEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.HooksUpdateRequestEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectsCreateRequestEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ChatsFindResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.MessageSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.VersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.DeploymentDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.DeploymentsFindLogsResponseLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.HookSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.VercelProjectSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.EnvironmentVariableSummarySchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ProjectsDeleteEnvVarsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.UserGetBillingResponseVariant1DataOnDemandBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ScopeSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ReportsGetUsageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ReportsGetAIUsageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.ReportsGetUserActivityResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::V0.McpServersFindResponseDataItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}