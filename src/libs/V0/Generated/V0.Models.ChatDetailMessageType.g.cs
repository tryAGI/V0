
#nullable enable

namespace V0
{
    /// <summary>
    /// Indicates the format or category of the message, such as plain text or code.
    /// </summary>
    public enum ChatDetailMessageType
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
    public static class ChatDetailMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatDetailMessageType value)
        {
            return value switch
            {
                ChatDetailMessageType.AddedEnvironmentVariables => "added-environment-variables",
                ChatDetailMessageType.AddedIntegration => "added-integration",
                ChatDetailMessageType.AnsweredQuestions => "answered-questions",
                ChatDetailMessageType.AutoFixWithV0 => "auto-fix-with-v0",
                ChatDetailMessageType.ClonedRepo => "cloned-repo",
                ChatDetailMessageType.DeletedFile => "deleted-file",
                ChatDetailMessageType.DesignMode => "design-mode",
                ChatDetailMessageType.EditedFile => "edited-file",
                ChatDetailMessageType.FixCve => "fix-cve",
                ChatDetailMessageType.FixWithV0 => "fix-with-v0",
                ChatDetailMessageType.ForkedBlock => "forked-block",
                ChatDetailMessageType.ForkedChat => "forked-chat",
                ChatDetailMessageType.ManualCommit => "manual-commit",
                ChatDetailMessageType.Message => "message",
                ChatDetailMessageType.MovedFile => "moved-file",
                ChatDetailMessageType.OpenInV0 => "open-in-v0",
                ChatDetailMessageType.PullChanges => "pull-changes",
                ChatDetailMessageType.Refinement => "refinement",
                ChatDetailMessageType.RenamedFile => "renamed-file",
                ChatDetailMessageType.ReplaceSrc => "replace-src",
                ChatDetailMessageType.RevertedBlock => "reverted-block",
                ChatDetailMessageType.SyncGit => "sync-git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatDetailMessageType? ToEnum(string value)
        {
            return value switch
            {
                "added-environment-variables" => ChatDetailMessageType.AddedEnvironmentVariables,
                "added-integration" => ChatDetailMessageType.AddedIntegration,
                "answered-questions" => ChatDetailMessageType.AnsweredQuestions,
                "auto-fix-with-v0" => ChatDetailMessageType.AutoFixWithV0,
                "cloned-repo" => ChatDetailMessageType.ClonedRepo,
                "deleted-file" => ChatDetailMessageType.DeletedFile,
                "design-mode" => ChatDetailMessageType.DesignMode,
                "edited-file" => ChatDetailMessageType.EditedFile,
                "fix-cve" => ChatDetailMessageType.FixCve,
                "fix-with-v0" => ChatDetailMessageType.FixWithV0,
                "forked-block" => ChatDetailMessageType.ForkedBlock,
                "forked-chat" => ChatDetailMessageType.ForkedChat,
                "manual-commit" => ChatDetailMessageType.ManualCommit,
                "message" => ChatDetailMessageType.Message,
                "moved-file" => ChatDetailMessageType.MovedFile,
                "open-in-v0" => ChatDetailMessageType.OpenInV0,
                "pull-changes" => ChatDetailMessageType.PullChanges,
                "refinement" => ChatDetailMessageType.Refinement,
                "renamed-file" => ChatDetailMessageType.RenamedFile,
                "replace-src" => ChatDetailMessageType.ReplaceSrc,
                "reverted-block" => ChatDetailMessageType.RevertedBlock,
                "sync-git" => ChatDetailMessageType.SyncGit,
                _ => null,
            };
        }
    }
}