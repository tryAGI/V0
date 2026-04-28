
#nullable enable

namespace V0
{
    /// <summary>
    /// Indicates the format or category of the message, such as plain text or code.
    /// </summary>
    public enum MessageDetailType
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
    public static class MessageDetailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDetailType value)
        {
            return value switch
            {
                MessageDetailType.AddedEnvironmentVariables => "added-environment-variables",
                MessageDetailType.AddedIntegration => "added-integration",
                MessageDetailType.AnsweredQuestions => "answered-questions",
                MessageDetailType.AutoFixWithV0 => "auto-fix-with-v0",
                MessageDetailType.ClonedRepo => "cloned-repo",
                MessageDetailType.DeletedFile => "deleted-file",
                MessageDetailType.DesignMode => "design-mode",
                MessageDetailType.EditedFile => "edited-file",
                MessageDetailType.FixCve => "fix-cve",
                MessageDetailType.FixWithV0 => "fix-with-v0",
                MessageDetailType.ForkedBlock => "forked-block",
                MessageDetailType.ForkedChat => "forked-chat",
                MessageDetailType.ManualCommit => "manual-commit",
                MessageDetailType.Message => "message",
                MessageDetailType.MovedFile => "moved-file",
                MessageDetailType.OpenInV0 => "open-in-v0",
                MessageDetailType.PullChanges => "pull-changes",
                MessageDetailType.Refinement => "refinement",
                MessageDetailType.RenamedFile => "renamed-file",
                MessageDetailType.ReplaceSrc => "replace-src",
                MessageDetailType.RevertedBlock => "reverted-block",
                MessageDetailType.SyncGit => "sync-git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDetailType? ToEnum(string value)
        {
            return value switch
            {
                "added-environment-variables" => MessageDetailType.AddedEnvironmentVariables,
                "added-integration" => MessageDetailType.AddedIntegration,
                "answered-questions" => MessageDetailType.AnsweredQuestions,
                "auto-fix-with-v0" => MessageDetailType.AutoFixWithV0,
                "cloned-repo" => MessageDetailType.ClonedRepo,
                "deleted-file" => MessageDetailType.DeletedFile,
                "design-mode" => MessageDetailType.DesignMode,
                "edited-file" => MessageDetailType.EditedFile,
                "fix-cve" => MessageDetailType.FixCve,
                "fix-with-v0" => MessageDetailType.FixWithV0,
                "forked-block" => MessageDetailType.ForkedBlock,
                "forked-chat" => MessageDetailType.ForkedChat,
                "manual-commit" => MessageDetailType.ManualCommit,
                "message" => MessageDetailType.Message,
                "moved-file" => MessageDetailType.MovedFile,
                "open-in-v0" => MessageDetailType.OpenInV0,
                "pull-changes" => MessageDetailType.PullChanges,
                "refinement" => MessageDetailType.Refinement,
                "renamed-file" => MessageDetailType.RenamedFile,
                "replace-src" => MessageDetailType.ReplaceSrc,
                "reverted-block" => MessageDetailType.RevertedBlock,
                "sync-git" => MessageDetailType.SyncGit,
                _ => null,
            };
        }
    }
}