
#nullable enable

namespace V0
{
    /// <summary>
    /// Whether to return decrypted values. Defaults to false (encrypted).
    /// </summary>
    public enum ProjectsCreateEnvVarsDecrypted
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsCreateEnvVarsDecryptedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsCreateEnvVarsDecrypted value)
        {
            return value switch
            {
                ProjectsCreateEnvVarsDecrypted.False => "false",
                ProjectsCreateEnvVarsDecrypted.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsCreateEnvVarsDecrypted? ToEnum(string value)
        {
            return value switch
            {
                "false" => ProjectsCreateEnvVarsDecrypted.False,
                "true" => ProjectsCreateEnvVarsDecrypted.True,
                _ => null,
            };
        }
    }
}