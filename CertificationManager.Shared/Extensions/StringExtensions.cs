using System.Linq;

namespace CertificationManager.Shared.Extensions
{
    public static class StringExtensions
    {
        private const char DefaultSeparator = ',';

        /// <summary>
        /// Converts to array.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        /// Array of the strings (Default separator ',' (Comma))
        /// </returns>
        public static string[] ToArrayText(this string text)
        {
            return ToArrayText(text, DefaultSeparator);
        }

        /// <summary>
        /// Converts to array.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>
        /// Array of the strings
        /// </returns>
        public static string[] ToArrayText(this string text, char separator)
        {
            return text?
                .Split(separator)
                .Select(s => s.Trim())
                .ToArray();
        }

        public static string ToCamelCase(this string str)
        {

            if (!string.IsNullOrEmpty(str) && str.Length > 1)
            {
                return char.ToLowerInvariant(str[0]) + str.Substring(1);
            }
            return str;

        }
    }
}
