
#nullable enable

namespace V0
{
    /// <summary>
    /// Whether to return decrypted values. Defaults to false (encrypted).
    /// </summary>
    public enum ProjectsGetEnvVarDecrypted
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
    public static class ProjectsGetEnvVarDecryptedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsGetEnvVarDecrypted value)
        {
            return value switch
            {
                ProjectsGetEnvVarDecrypted.False => "false",
                ProjectsGetEnvVarDecrypted.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsGetEnvVarDecrypted? ToEnum(string value)
        {
            return value switch
            {
                "false" => ProjectsGetEnvVarDecrypted.False,
                "true" => ProjectsGetEnvVarDecrypted.True,
                _ => null,
            };
        }
    }
}