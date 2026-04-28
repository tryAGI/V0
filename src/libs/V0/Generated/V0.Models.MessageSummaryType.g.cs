
#nullable enable

namespace V0
{
    /// <summary>
    /// Indicates the format or category of the message, such as plain text or code.
    /// </summary>
    public enum MessageSummaryType
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
    public static class MessageSummaryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSummaryType value)
        {
            return value switch
            {
                MessageSummaryType.AddedEnvironmentVariables => "added-environment-variables",
                MessageSummaryType.AddedIntegration => "added-integration",
                MessageSummaryType.AnsweredQuestions => "answered-questions",
                MessageSummaryType.AutoFixWithV0 => "auto-fix-with-v0",
                MessageSummaryType.ClonedRepo => "cloned-repo",
                MessageSummaryType.DeletedFile => "deleted-file",
                MessageSummaryType.DesignMode => "design-mode",
                MessageSummaryType.EditedFile => "edited-file",
                MessageSummaryType.FixCve => "fix-cve",
                MessageSummaryType.FixWithV0 => "fix-with-v0",
                MessageSummaryType.ForkedBlock => "forked-block",
                MessageSummaryType.ForkedChat => "forked-chat",
                MessageSummaryType.ManualCommit => "manual-commit",
                MessageSummaryType.Message => "message",
                MessageSummaryType.MovedFile => "moved-file",
                MessageSummaryType.OpenInV0 => "open-in-v0",
                MessageSummaryType.PullChanges => "pull-changes",
                MessageSummaryType.Refinement => "refinement",
                MessageSummaryType.RenamedFile => "renamed-file",
                MessageSummaryType.ReplaceSrc => "replace-src",
                MessageSummaryType.RevertedBlock => "reverted-block",
                MessageSummaryType.SyncGit => "sync-git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSummaryType? ToEnum(string value)
        {
            return value switch
            {
                "added-environment-variables" => MessageSummaryType.AddedEnvironmentVariables,
                "added-integration" => MessageSummaryType.AddedIntegration,
                "answered-questions" => MessageSummaryType.AnsweredQuestions,
                "auto-fix-with-v0" => MessageSummaryType.AutoFixWithV0,
                "cloned-repo" => MessageSummaryType.ClonedRepo,
                "deleted-file" => MessageSummaryType.DeletedFile,
                "design-mode" => MessageSummaryType.DesignMode,
                "edited-file" => MessageSummaryType.EditedFile,
                "fix-cve" => MessageSummaryType.FixCve,
                "fix-with-v0" => MessageSummaryType.FixWithV0,
                "forked-block" => MessageSummaryType.ForkedBlock,
                "forked-chat" => MessageSummaryType.ForkedChat,
                "manual-commit" => MessageSummaryType.ManualCommit,
                "message" => MessageSummaryType.Message,
                "moved-file" => MessageSummaryType.MovedFile,
                "open-in-v0" => MessageSummaryType.OpenInV0,
                "pull-changes" => MessageSummaryType.PullChanges,
                "refinement" => MessageSummaryType.Refinement,
                "renamed-file" => MessageSummaryType.RenamedFile,
                "replace-src" => MessageSummaryType.ReplaceSrc,
                "reverted-block" => MessageSummaryType.RevertedBlock,
                "sync-git" => MessageSummaryType.SyncGit,
                _ => null,
            };
        }
    }
}