
#nullable enable

namespace V0
{
    /// <summary>
    /// Indicates the format or category of the message, such as plain text or code.
    /// </summary>
    public enum MessageSummaryListDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AddedEnvironmentVariables,
        /// <summary>
        /// 
        /// </summary>
        AddedIntegration,
        /// <summary>
        /// 
        /// </summary>
        AnsweredQuestions,
        /// <summary>
        /// 
        /// </summary>
        AutoFixWithV0,
        /// <summary>
        /// 
        /// </summary>
        ClonedRepo,
        /// <summary>
        /// 
        /// </summary>
        DeletedFile,
        /// <summary>
        /// 
        /// </summary>
        DesignMode,
        /// <summary>
        /// 
        /// </summary>
        EditedFile,
        /// <summary>
        /// 
        /// </summary>
        FixCve,
        /// <summary>
        /// 
        /// </summary>
        FixWithV0,
        /// <summary>
        /// 
        /// </summary>
        ForkedBlock,
        /// <summary>
        /// 
        /// </summary>
        ForkedChat,
        /// <summary>
        /// 
        /// </summary>
        ManualCommit,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        MovedFile,
        /// <summary>
        /// 
        /// </summary>
        OpenInV0,
        /// <summary>
        /// 
        /// </summary>
        PullChanges,
        /// <summary>
        /// 
        /// </summary>
        Refinement,
        /// <summary>
        /// 
        /// </summary>
        RenamedFile,
        /// <summary>
        /// 
        /// </summary>
        ReplaceSrc,
        /// <summary>
        /// 
        /// </summary>
        RevertedBlock,
        /// <summary>
        /// 
        /// </summary>
        SyncGit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageSummaryListDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSummaryListDataItemType value)
        {
            return value switch
            {
                MessageSummaryListDataItemType.AddedEnvironmentVariables => "added-environment-variables",
                MessageSummaryListDataItemType.AddedIntegration => "added-integration",
                MessageSummaryListDataItemType.AnsweredQuestions => "answered-questions",
                MessageSummaryListDataItemType.AutoFixWithV0 => "auto-fix-with-v0",
                MessageSummaryListDataItemType.ClonedRepo => "cloned-repo",
                MessageSummaryListDataItemType.DeletedFile => "deleted-file",
                MessageSummaryListDataItemType.DesignMode => "design-mode",
                MessageSummaryListDataItemType.EditedFile => "edited-file",
                MessageSummaryListDataItemType.FixCve => "fix-cve",
                MessageSummaryListDataItemType.FixWithV0 => "fix-with-v0",
                MessageSummaryListDataItemType.ForkedBlock => "forked-block",
                MessageSummaryListDataItemType.ForkedChat => "forked-chat",
                MessageSummaryListDataItemType.ManualCommit => "manual-commit",
                MessageSummaryListDataItemType.Message => "message",
                MessageSummaryListDataItemType.MovedFile => "moved-file",
                MessageSummaryListDataItemType.OpenInV0 => "open-in-v0",
                MessageSummaryListDataItemType.PullChanges => "pull-changes",
                MessageSummaryListDataItemType.Refinement => "refinement",
                MessageSummaryListDataItemType.RenamedFile => "renamed-file",
                MessageSummaryListDataItemType.ReplaceSrc => "replace-src",
                MessageSummaryListDataItemType.RevertedBlock => "reverted-block",
                MessageSummaryListDataItemType.SyncGit => "sync-git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSummaryListDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "added-environment-variables" => MessageSummaryListDataItemType.AddedEnvironmentVariables,
                "added-integration" => MessageSummaryListDataItemType.AddedIntegration,
                "answered-questions" => MessageSummaryListDataItemType.AnsweredQuestions,
                "auto-fix-with-v0" => MessageSummaryListDataItemType.AutoFixWithV0,
                "cloned-repo" => MessageSummaryListDataItemType.ClonedRepo,
                "deleted-file" => MessageSummaryListDataItemType.DeletedFile,
                "design-mode" => MessageSummaryListDataItemType.DesignMode,
                "edited-file" => MessageSummaryListDataItemType.EditedFile,
                "fix-cve" => MessageSummaryListDataItemType.FixCve,
                "fix-with-v0" => MessageSummaryListDataItemType.FixWithV0,
                "forked-block" => MessageSummaryListDataItemType.ForkedBlock,
                "forked-chat" => MessageSummaryListDataItemType.ForkedChat,
                "manual-commit" => MessageSummaryListDataItemType.ManualCommit,
                "message" => MessageSummaryListDataItemType.Message,
                "moved-file" => MessageSummaryListDataItemType.MovedFile,
                "open-in-v0" => MessageSummaryListDataItemType.OpenInV0,
                "pull-changes" => MessageSummaryListDataItemType.PullChanges,
                "refinement" => MessageSummaryListDataItemType.Refinement,
                "renamed-file" => MessageSummaryListDataItemType.RenamedFile,
                "replace-src" => MessageSummaryListDataItemType.ReplaceSrc,
                "reverted-block" => MessageSummaryListDataItemType.RevertedBlock,
                "sync-git" => MessageSummaryListDataItemType.SyncGit,
                _ => null,
            };
        }
    }
}