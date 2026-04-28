
#nullable enable

namespace V0
{
    /// <summary>
    /// Whether to return decrypted values. Defaults to false (encrypted).
    /// </summary>
    public enum ProjectsFindEnvVarsDecrypted
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
    public static class ProjectsFindEnvVarsDecryptedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsFindEnvVarsDecrypted value)
        {
            return value switch
            {
                ProjectsFindEnvVarsDecrypted.False => "false",
                ProjectsFindEnvVarsDecrypted.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsFindEnvVarsDecrypted? ToEnum(string value)
        {
            return value switch
            {
                "false" => ProjectsFindEnvVarsDecrypted.False,
                "true" => ProjectsFindEnvVarsDecrypted.True,
                _ => null,
            };
        }
    }
}