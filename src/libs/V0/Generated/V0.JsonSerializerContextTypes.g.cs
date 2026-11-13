
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::V0.ChatDetailMessageAttachmentImageDimensions? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailMessageAttachmentType? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatDetailFile>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailFile? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailModelConfiguration? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatDetailModelConfigurationModelId?, string>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailModelConfigurationModelId? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailModelConfigurationThinkingEffort? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatDetailPermissions? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummary? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummaryPrivacy? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummaryLatestVersion? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatSummaryLatestVersionStatus? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentDetail? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentSummary? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariableDetailSchema? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariableSummarySchema? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariablesListSchema? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.EnvironmentVariablesListSchemaDataItem>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.EnvironmentVariablesListSchemaDataItem? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.FileDetail? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.FileSummary? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookDetail? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HookDetailEvent>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookDetailEvent? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookEventDetail? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookEventDetailEvent? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookEventDetailStatus? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HookSummary? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionDetailSchema? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionDetailSchemaIntegration? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionListSchema? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.IntegrationConnectionListSchemaDataItem>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionListSchemaDataItem? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionListSchemaDataItemIntegration? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionSummarySchema? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationConnectionSummarySchemaIntegration? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationDetailSchema? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationListSchema? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.IntegrationListSchemaDataItem>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationListSchemaDataItem? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationSummarySchema? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetail? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailType? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailRole? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailFinishReason? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageDetailAttachment>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailAttachment? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailAttachmentImageDimensions? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageDetailAttachmentType? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummary? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryType? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryRole? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryFinishReason? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummaryAttachment>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryAttachment? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryAttachmentImageDimensions? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryAttachmentType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryList? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummaryListDataItem>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItem? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemType? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemRole? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemFinishReason? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummaryListDataItemAttachment>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemAttachment? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemAttachmentImageDimensions? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListDataItemAttachmentType? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.MessageSummaryListPagination? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.NotificationPreferenceSchema? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductDetailSchema? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductDetailSchemaV0Availability? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductListSchema? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProductListSchemaDataItem>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductListSchemaDataItem? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductListSchemaDataItemV0Availability? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductSummarySchema? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProductSummarySchemaV0Availability? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetail? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailPrivacy? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectDetailChat>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChat? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChatPrivacy? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChatLatestVersion? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectDetailChatLatestVersionStatus? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectSummary? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectSummaryPrivacy? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ScopeSummary? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.SearchResultItem? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.SearchResultItemObject? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserDetailSchema? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesPostResponseSchema? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesPostResponseSchemaPreferences? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesPostResponseSchemaPreferencesNotifications? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesResponseSchema? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesResponseSchemaPreferences? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesResponseSchemaPreferencesNotifications? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesSchema? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserPreferencesSchemaNotifications? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserSummarySchema? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VercelProjectDetail? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VercelProjectSummary? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionDetail? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionDetailStatus? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VersionDetailFile>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionDetailFile? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummary? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryStatus? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryList? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VersionSummaryListDataItem>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryListDataItem? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryListDataItemStatus? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.VersionSummaryListPagination? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnauthorizedError? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnauthorizedErrorError? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ForbiddenError? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ForbiddenErrorError? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.NotFoundError? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.NotFoundErrorError? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ConflictError? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ConflictErrorError? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.PayloadTooLargeError? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.PayloadTooLargeErrorError? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnprocessableEntityError? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UnprocessableEntityErrorError? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.TooManyRequestsError? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.TooManyRequestsErrorError? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.InternalServerError? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.InternalServerErrorError? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequest? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsCreateRequestAttachment>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestAttachment? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestChatPrivacy? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestModelConfiguration? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsCreateRequestModelConfigurationModelId?, string>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestModelConfigurationModelId? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestModelConfigurationThinkingEffort? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestResponseMode? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsCreateRequestSkillVariant1, global::V0.ChatsCreateRequestSkillVariant2, global::V0.ChatsCreateRequestSkillVariant3>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant1? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant1Type? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant2? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant2Type? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant2Scope? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant3? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsCreateRequestSkillVariant3Type? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequest2? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestChatPrivacy? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant1? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsInitRequestVariant1FileVariant1, global::V0.ChatsInitRequestVariant1FileVariant2>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant1FileVariant1? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant1FileVariant2? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant22? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant2Repo? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant3? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant3Registry? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant4? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant4Zip? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsInitRequestVariant5? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateRequest? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateRequestPrivacy? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFavoriteRequest? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsForkRequest? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsForkRequestPrivacy? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequest? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsSendMessageRequestAttachment>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestAttachment? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestModelConfiguration? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsSendMessageRequestModelConfigurationModelId?, string>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestModelConfigurationModelId? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestModelConfigurationThinkingEffort? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestResponseMode? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant1? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant1Type? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant2? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant2Type? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant2Scope? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant3? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestSkillVariant3Type? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsSendMessageRequestAction? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateVersionRequest? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsUpdateVersionRequestFile>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsUpdateVersionRequestFile? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDeleteVersionFilesRequest? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequest? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant1? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant1Type? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant1ConnectedMcpPresetName? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant2? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant2Type? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant2Status? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant3? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant3Type? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant3Answer>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant3Answer? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4Type? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsResolveTaskRequestTaskVariant4Permission>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4Permission? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant4PermissionType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant5? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant5Type? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant6? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestTaskVariant6Type? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestResponseMode? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestModelConfiguration? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.ChatsResolveTaskRequestModelConfigurationModelId?, string>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestModelConfigurationModelId? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsResolveTaskRequestModelConfigurationThinkingEffort? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsCreateRequest? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksCreateRequest? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HooksCreateRequestEvent>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksCreateRequestEvent? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksUpdateRequest? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HooksUpdateRequestEvent>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksUpdateRequestEvent? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationsVercelProjectsCreateRequest? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateRequest? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsCreateRequestEnvironmentVariable>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateRequestEnvironmentVariable? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateRequestPrivacy? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateRequest? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateRequestPrivacy? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsAssignRequest? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsRequest? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsRequestEnvironmentVariable? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsRequest? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsRequestEnvironmentVariable? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteEnvVarsRequest? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequest? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant1? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant2? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant3? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant4? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestAuthVariant4Config? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateRequestScope? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequest? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant1? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant2? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant3? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant4? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestAuthVariant4Config? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateRequestScope? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateOAuthAuthorizationUrlRequest? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindIsFavorite? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsGetVersionIncludeDefaultFiles? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDownloadVersionFormat? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDownloadVersionIncludeDefaultFiles? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteDeleteAllChats? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsFindEnvVarsDecrypted? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsDecrypted? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsDecrypted? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsGetEnvVarDecrypted? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponse? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ChatsFindResponseDataItem>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItem? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItemPrivacy? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItemLatestVersion? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindResponseDataItemLatestVersionStatus? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsDeleteResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFavoriteResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindMessagesResponse? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.MessageSummary>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindMessagesResponsePagination? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindVersionsResponse? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VersionSummary>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindVersionsResponsePagination? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsFindVersionsResponseMeta? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ChatsStopResponse? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindResponse? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.DeploymentDetail>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsDeleteResponse? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponse? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.DeploymentsFindLogsResponseLog>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponseLog? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponseLogType? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindLogsResponseLogLevel? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.DeploymentsFindErrorsResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksFindResponse? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.HookSummary>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.HooksDeleteResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.IntegrationsVercelProjectsFindResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.VercelProjectSummary>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsFindResponse? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectSummary>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteResponse? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsAssignResponse? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsFindEnvVarsResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.EnvironmentVariableSummarySchema>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsCreateEnvVarsResponse? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsUpdateEnvVarsResponse? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteEnvVarsResponse? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ProjectsDeleteEnvVarsResponseDataItem>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsDeleteEnvVarsResponseDataItem? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ProjectsGetEnvVarResponse? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.RateLimitsFindResponse? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.RateLimitsFindResponseDailyLimit? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.AnyOf<global::V0.UserGetBillingResponseVariant1, global::V0.UserGetBillingResponseVariant2>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1Data? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataBillingCycle? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataBalance? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataOnDemand? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.UserGetBillingResponseVariant1DataOnDemandBlock>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant1DataOnDemandBlock? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant2? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetBillingResponseVariant2Data? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetPlanResponse? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetPlanResponseBillingCycle? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetPlanResponseBalance? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.UserGetScopesResponse? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ScopeSummary>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponse? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ReportsGetUsageResponseDataItem>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseDataItem? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseDataItemType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseDataItemCostBreakdownStatus? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponsePagination? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUsageResponseMeta? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponse? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ReportsGetAIUsageResponseDataItem>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponseDataItem? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponsePagination? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetAIUsageResponseDateRange? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponse? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.ReportsGetUserActivityResponseDataItem>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseDataItem? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseDataItemUser? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseDataItemUserTeamV0Role? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseMeta? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.ReportsGetUserActivityResponseMetaDateRange? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponse? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::V0.McpServersFindResponseDataItem>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItem? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItemAuth? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItemAuthType? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersFindResponseDataItemScope? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponse? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponseAuth? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponseAuthType? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateResponseScope? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponseAuth? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponseAuthType? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersGetByIdResponseScope? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponse? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponseAuth? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponseAuthType? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersUpdateResponseScope? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersDeleteResponse? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::V0.McpServersCreateOAuthAuthorizationUrlResponse? Type378 { get; set; }

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