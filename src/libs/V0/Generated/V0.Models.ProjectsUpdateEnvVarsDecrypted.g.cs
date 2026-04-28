
#nullable enable

namespace V0
{
    /// <summary>
    /// Whether to return decrypted values. Defaults to false (encrypted).
    /// </summary>
    public enum ProjectsUpdateEnvVarsDecrypted
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
    public static class ProjectsUpdateEnvVarsDecryptedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsUpdateEnvVarsDecrypted value)
        {
            return value switch
            {
                ProjectsUpdateEnvVarsDecrypted.False => "false",
                ProjectsUpdateEnvVarsDecrypted.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsUpdateEnvVarsDecrypted? ToEnum(string value)
        {
            return value switch
            {
                "false" => ProjectsUpdateEnvVarsDecrypted.False,
                "true" => ProjectsUpdateEnvVarsDecrypted.True,
                _ => null,
            };
        }
    }
}