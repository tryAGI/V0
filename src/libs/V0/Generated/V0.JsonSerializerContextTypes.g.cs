
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace V0
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetail? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailPrivacy? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailLatestVersion? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailLatestVersionStatus? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatDetailLatestVersionFile>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailLatestVersionFile? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatDetailMessage>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailMessage? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailMessageType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailMessageRole? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailMessageFinishReason? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatDetailMessageAttachment>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailMessageAttachment? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailMessageAttachmentType? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatDetailFile>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailFile? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailModelConfiguration? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatDetailModelConfigurationModelId?, string>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailModelConfigurationModelId? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailModelConfigurationThinkingEffort? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailPermissions? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummary? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummaryPrivacy? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummaryLatestVersion? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummaryLatestVersionStatus? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentDetail? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentSummary? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariableDetailSchema? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariableSummarySchema? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariablesListSchema? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.EnvironmentVariablesListSchemaDataItem>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariablesListSchemaDataItem? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.FileDetail? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.FileSummary? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookDetail? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HookDetailEvent>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookDetailEvent? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookEventDetail? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookEventDetailEvent? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookEventDetailStatus? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookSummary? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionDetailSchema? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionDetailSchemaIntegration? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionListSchema? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.IntegrationConnectionListSchemaDataItem>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionListSchemaDataItem? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionListSchemaDataItemIntegration? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionSummarySchema? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionSummarySchemaIntegration? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationDetailSchema? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationListSchema? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.IntegrationListSchemaDataItem>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationListSchemaDataItem? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationSummarySchema? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetail? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailRole? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailFinishReason? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageDetailAttachment>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailAttachment? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailAttachmentType? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummary? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryRole? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryFinishReason? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummaryAttachment>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryAttachment? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryAttachmentType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryList? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummaryListDataItem>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItem? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemRole? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemFinishReason? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummaryListDataItemAttachment>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemAttachment? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemAttachmentType? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListPagination? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.NotificationPreferenceSchema? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductDetailSchema? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductDetailSchemaV0Availability? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductListSchema? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProductListSchemaDataItem>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductListSchemaDataItem? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductListSchemaDataItemV0Availability? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductSummarySchema? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductSummarySchemaV0Availability? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetail? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailPrivacy? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectDetailChat>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChat? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChatPrivacy? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChatLatestVersion? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChatLatestVersionStatus? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectSummary? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectSummaryPrivacy? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ScopeSummary? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.SearchResultItem? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.SearchResultItemObject? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserDetailSchema? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesPostResponseSchema? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesPostResponseSchemaPreferences? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesPostResponseSchemaPreferencesNotifications? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesResponseSchema? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesResponseSchemaPreferences? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesResponseSchemaPreferencesNotifications? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesSchema? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesSchemaNotifications? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserSummarySchema? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VercelProjectDetail? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VercelProjectSummary? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionDetail? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionDetailStatus? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VersionDetailFile>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionDetailFile? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummary? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryStatus? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryList? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VersionSummaryListDataItem>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryListDataItem? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryListDataItemStatus? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryListPagination? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnauthorizedError? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnauthorizedErrorError? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ForbiddenError? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ForbiddenErrorError? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.NotFoundError? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.NotFoundErrorError? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ConflictError? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ConflictErrorError? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.PayloadTooLargeError? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.PayloadTooLargeErrorError? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnprocessableEntityError? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnprocessableEntityErrorError? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.TooManyRequestsError? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.TooManyRequestsErrorError? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.InternalServerError? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.InternalServerErrorError? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsCreateRequestAttachment>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestAttachment? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestChatPrivacy? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestModelConfiguration? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsCreateRequestModelConfigurationModelId?, string>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestModelConfigurationModelId? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestModelConfigurationThinkingEffort? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestResponseMode? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant1? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant1Type? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant2? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant2Type? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant2Scope? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant3? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant3Type? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequest2? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestChatPrivacy? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant1? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant1FileVariant1? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant1FileVariant2? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant22? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant2Repo? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant3? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant3Registry? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant4? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant4Zip? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant5? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateRequest? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateRequestPrivacy? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFavoriteRequest? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsForkRequest? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsForkRequestPrivacy? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequest? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsSendMessageRequestAttachment>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestAttachment? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestModelConfiguration? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsSendMessageRequestModelConfigurationModelId?, string>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestModelConfigurationModelId? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestModelConfigurationThinkingEffort? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestResponseMode? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant1? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant1Type? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant2? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant2Type? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant2Scope? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant3? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant3Type? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestAction? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateVersionRequest? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsUpdateVersionRequestFile>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateVersionRequestFile? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDeleteVersionFilesRequest? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant1? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant1Type? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant2? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant2Type? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant2Status? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant3? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant3Type? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant3Answer>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant3Answer? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4Type? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant4Permission>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4Permission? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4PermissionType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant5? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant5Type? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant6? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant6Type? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestResponseMode? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestModelConfiguration? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsResolveTaskRequestModelConfigurationModelId?, string>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestModelConfigurationModelId? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestModelConfigurationThinkingEffort? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsCreateRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksCreateRequest? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HooksCreateRequestEvent>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksCreateRequestEvent? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksUpdateRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HooksUpdateRequestEvent>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksUpdateRequestEvent? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationsVercelProjectsCreateRequest? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateRequest? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsCreateRequestEnvironmentVariable>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateRequestEnvironmentVariable? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateRequestPrivacy? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateRequest? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateRequestPrivacy? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsAssignRequest? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsRequest? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteEnvVarsRequest? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequest? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant1? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant2? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant3? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant4? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant4Config? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestScope? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant1? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant2? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant3? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant4? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant4Config? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestScope? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateOAuthAuthorizationUrlRequest? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindIsFavorite? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsGetVersionIncludeDefaultFiles? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDownloadVersionFormat? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDownloadVersionIncludeDefaultFiles? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteDeleteAllChats? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsFindEnvVarsDecrypted? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsDecrypted? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsDecrypted? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsGetEnvVarDecrypted? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponse? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsFindResponseDataItem>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItem? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItemPrivacy? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItemLatestVersion? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItemLatestVersionStatus? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDeleteResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFavoriteResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindMessagesResponse? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummary>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindMessagesResponsePagination? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindVersionsResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VersionSummary>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindVersionsResponsePagination? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindVersionsResponseMeta? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsStopResponse? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindResponse? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.DeploymentDetail>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsDeleteResponse? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponse? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.DeploymentsFindLogsResponseLog>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponseLog? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponseLogType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponseLogLevel? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindErrorsResponse? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksFindResponse? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HookSummary>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksDeleteResponse? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationsVercelProjectsFindResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VercelProjectSummary>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsFindResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectSummary>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsAssignResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsFindEnvVarsResponse? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.EnvironmentVariableSummarySchema>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsResponse? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsResponse? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteEnvVarsResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsDeleteEnvVarsResponseDataItem>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteEnvVarsResponseDataItem? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsGetEnvVarResponse? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.RateLimitsFindResponse? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.RateLimitsFindResponseDailyLimit? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.UserGetBillingResponseVariant1, global::V0.UserGetBillingResponseVariant2>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1Data? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataBillingCycle? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataBalance? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataOnDemand? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.UserGetBillingResponseVariant1DataOnDemandBlock>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataOnDemandBlock? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant2? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant2Data? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetPlanResponse? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetPlanResponseBillingCycle? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetPlanResponseBalance? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetScopesResponse? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ScopeSummary>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ReportsGetUsageResponseDataItem>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseDataItem? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseDataItemType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseDataItemCostBreakdownStatus? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponsePagination? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseMeta? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponse? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ReportsGetAIUsageResponseDataItem>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponseDataItem? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponsePagination? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponseDateRange? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponse? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ReportsGetUserActivityResponseDataItem>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseDataItem? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseDataItemUser? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseDataItemUserTeamV0Role? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseMeta? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseMetaDateRange? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponse? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.McpServersFindResponseDataItem>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItem? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItemAuth? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItemAuthType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItemScope? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponse? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponseAuth? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponseAuthType? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponseScope? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponse? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponseAuth? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponseAuthType? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponseScope? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponseAuth? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponseAuthType? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponseScope? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersDeleteResponse? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateOAuthAuthorizationUrlResponse? Type374 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatDetailLatestVersionFile>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatDetailMessage>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatDetailMessageAttachment>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatDetailFile>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.EnvironmentVariablesListSchemaDataItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.HookDetailEvent>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.IntegrationConnectionListSchemaDataItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.IntegrationListSchemaDataItem>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.MessageDetailAttachment>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.MessageSummaryAttachment>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.MessageSummaryListDataItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.MessageSummaryListDataItemAttachment>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ProductListSchemaDataItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ProjectDetailChat>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.VersionDetailFile>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.VersionSummaryListDataItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatsCreateRequestAttachment>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatsSendMessageRequestAttachment>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatsUpdateVersionRequestFile>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatsResolveTaskRequestTaskVariant3Answer>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatsResolveTaskRequestTaskVariant4Permission>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.HooksCreateRequestEvent>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.HooksUpdateRequestEvent>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ProjectsCreateRequestEnvironmentVariable>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ChatsFindResponseDataItem>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.MessageSummary>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.VersionSummary>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.DeploymentDetail>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.DeploymentsFindLogsResponseLog>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.HookSummary>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.VercelProjectSummary>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ProjectSummary>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.EnvironmentVariableSummarySchema>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ProjectsDeleteEnvVarsResponseDataItem>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.UserGetBillingResponseVariant1DataOnDemandBlock>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ScopeSummary>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ReportsGetUsageResponseDataItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ReportsGetAIUsageResponseDataItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.ReportsGetUserActivityResponseDataItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::V0.McpServersFindResponseDataItem>? ListType46 { get; set; }
    }
}