
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
        public global::V0.ChatDetailModelConfigurationModelId? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailModelConfigurationThinkingEffort? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailPermissions? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummary? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummaryPrivacy? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummaryLatestVersion? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummaryLatestVersionStatus? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentDetail? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentSummary? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariableDetailSchema? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariableSummarySchema? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariablesListSchema? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.EnvironmentVariablesListSchemaDataItem>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariablesListSchemaDataItem? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.FileDetail? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.FileSummary? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookDetail? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HookDetailEvent>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookDetailEvent? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookEventDetail? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookEventDetailEvent? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookEventDetailStatus? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookSummary? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionDetailSchema? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionDetailSchemaIntegration? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionListSchema? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.IntegrationConnectionListSchemaDataItem>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionListSchemaDataItem? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionListSchemaDataItemIntegration? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionSummarySchema? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionSummarySchemaIntegration? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationDetailSchema? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationListSchema? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.IntegrationListSchemaDataItem>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationListSchemaDataItem? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationSummarySchema? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetail? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailRole? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailFinishReason? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageDetailAttachment>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailAttachment? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailAttachmentType? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummary? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryRole? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryFinishReason? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummaryAttachment>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryAttachment? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryAttachmentType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryList? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummaryListDataItem>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItem? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemType? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemRole? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemFinishReason? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummaryListDataItemAttachment>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemAttachment? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemAttachmentType? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListPagination? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.NotificationPreferenceSchema? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductDetailSchema? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductDetailSchemaV0Availability? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductListSchema? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProductListSchemaDataItem>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductListSchemaDataItem? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductListSchemaDataItemV0Availability? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductSummarySchema? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductSummarySchemaV0Availability? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetail? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailPrivacy? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectDetailChat>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChat? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChatPrivacy? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChatLatestVersion? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChatLatestVersionStatus? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectSummary? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectSummaryPrivacy? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ScopeSummary? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.SearchResultItem? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.SearchResultItemObject? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserDetailSchema? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesPostResponseSchema? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesPostResponseSchemaPreferences? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesPostResponseSchemaPreferencesNotifications? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesResponseSchema? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesResponseSchemaPreferences? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesResponseSchemaPreferencesNotifications? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesSchema? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesSchemaNotifications? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserSummarySchema? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VercelProjectDetail? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VercelProjectSummary? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionDetail? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionDetailStatus? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VersionDetailFile>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionDetailFile? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummary? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryStatus? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryList? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VersionSummaryListDataItem>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryListDataItem? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryListDataItemStatus? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryListPagination? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnauthorizedError? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnauthorizedErrorError? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ForbiddenError? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ForbiddenErrorError? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.NotFoundError? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.NotFoundErrorError? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ConflictError? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ConflictErrorError? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.PayloadTooLargeError? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.PayloadTooLargeErrorError? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnprocessableEntityError? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnprocessableEntityErrorError? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.TooManyRequestsError? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.TooManyRequestsErrorError? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.InternalServerError? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.InternalServerErrorError? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsCreateRequestAttachment>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestAttachment? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestChatPrivacy? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestModelConfiguration? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestModelConfigurationModelId? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestModelConfigurationThinkingEffort? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestResponseMode? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant1? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant1Type? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant2? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant2Type? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant2Scope? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant3? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant3Type? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequest2? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestChatPrivacy? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant1? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant1FileVariant1? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant1FileVariant2? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant22? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant2Repo? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant3? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant3Registry? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant4? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant4Zip? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant5? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateRequest? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateRequestPrivacy? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFavoriteRequest? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsForkRequest? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsForkRequestPrivacy? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequest? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsSendMessageRequestAttachment>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestAttachment? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestModelConfiguration? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestModelConfigurationModelId? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestModelConfigurationThinkingEffort? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestResponseMode? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant1? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant1Type? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant2? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant2Type? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant2Scope? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant3? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant3Type? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestAction? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateVersionRequest? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsUpdateVersionRequestFile>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateVersionRequestFile? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDeleteVersionFilesRequest? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant1? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant1Type? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant2? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant2Type? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant2Status? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant3? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant3Type? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant3Answer>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant3Answer? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4Type? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant4Permission>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4Permission? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4PermissionType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant5? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant5Type? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant6? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant6Type? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestResponseMode? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestModelConfiguration? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestModelConfigurationModelId? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestModelConfigurationThinkingEffort? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsCreateRequest? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksCreateRequest? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HooksCreateRequestEvent>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksCreateRequestEvent? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksUpdateRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HooksUpdateRequestEvent>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksUpdateRequestEvent? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationsVercelProjectsCreateRequest? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsCreateRequestEnvironmentVariable>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateRequestEnvironmentVariable? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateRequestPrivacy? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateRequest? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateRequestPrivacy? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsAssignRequest? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsRequest? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteEnvVarsRequest? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant1? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant2? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant3? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant4? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant4Config? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestScope? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequest? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant1? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant2? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant3? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant4? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant4Config? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestScope? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateOAuthAuthorizationUrlRequest? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindIsFavorite? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsGetVersionIncludeDefaultFiles? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDownloadVersionFormat? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDownloadVersionIncludeDefaultFiles? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteDeleteAllChats? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsFindEnvVarsDecrypted? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsDecrypted? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsDecrypted? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsGetEnvVarDecrypted? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsFindResponseDataItem>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItem? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItemPrivacy? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItemLatestVersion? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItemLatestVersionStatus? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDeleteResponse? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFavoriteResponse? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindMessagesResponse? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummary>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindMessagesResponsePagination? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindVersionsResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VersionSummary>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindVersionsResponsePagination? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindVersionsResponseMeta? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsStopResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindResponse? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.DeploymentDetail>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsDeleteResponse? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponse? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.DeploymentsFindLogsResponseLog>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponseLog? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponseLogType? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponseLogLevel? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindErrorsResponse? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksFindResponse? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HookSummary>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksDeleteResponse? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationsVercelProjectsFindResponse? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VercelProjectSummary>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsFindResponse? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectSummary>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsAssignResponse? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsFindEnvVarsResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.EnvironmentVariableSummarySchema>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteEnvVarsResponse? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsDeleteEnvVarsResponseDataItem>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteEnvVarsResponseDataItem? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsGetEnvVarResponse? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.RateLimitsFindResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.RateLimitsFindResponseDailyLimit? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.UserGetBillingResponseVariant1, global::V0.UserGetBillingResponseVariant2>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1Data? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataBillingCycle? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataBalance? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataOnDemand? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.UserGetBillingResponseVariant1DataOnDemandBlock>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataOnDemandBlock? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant2? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant2Data? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetPlanResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetPlanResponseBillingCycle? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetPlanResponseBalance? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetScopesResponse? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ScopeSummary>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponse? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ReportsGetUsageResponseDataItem>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseDataItem? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseDataItemType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseDataItemCostBreakdownStatus? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponsePagination? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseMeta? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponse? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ReportsGetAIUsageResponseDataItem>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponseDataItem? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponsePagination? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponseDateRange? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponse? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ReportsGetUserActivityResponseDataItem>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseDataItem? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseDataItemUser? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseDataItemUserTeamV0Role? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseMeta? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseMetaDateRange? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponse? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.McpServersFindResponseDataItem>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItem? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItemAuth? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItemAuthType? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItemScope? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponse? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponseAuth? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponseAuthType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponseScope? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponse? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponseAuth? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponseAuthType? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponseScope? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponse? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponseAuth? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponseAuthType? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponseScope? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersDeleteResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateOAuthAuthorizationUrlResponse? Type370 { get; set; }

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