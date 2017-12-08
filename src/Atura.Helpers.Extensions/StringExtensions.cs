using System.Diagnostics;

namespace Atura.Helpers.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns true if a string is null or whitespace
        /// </summary>
        [DebuggerStepThrough]
        public static bool IsMissing(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Returns true if a string is not null or whitespace
        /// </summary>
        [DebuggerStepThrough]
        public static bool IsPresent(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
