using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Zin.StringUtils
{
    public static class StringUtils
    {
        public static string NormalizeText(this string str)
        {
            if (null == str) return null;

            StringBuilder sb = new StringBuilder();

            var chars =
                from c in str.Normalize(NormalizationForm.FormD).ToCharArray()
                let uc = CharUnicodeInfo.GetUnicodeCategory(c)
                where uc != UnicodeCategory.NonSpacingMark
                select c;

            sb.Append(chars.ToArray());
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return sb.ToString().Normalize(NormalizationForm.FormC);

        }

        public static string NormalizeTextByRegex(this string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);

            return regex.Replace(temp, String.Empty)
                .Replace('\u0111', 'd')
                .Replace('\u0110', 'D');

        }

        public static string ReplaceWhitespace(this string str, string replacedString = default)
        {
            return System.Text.RegularExpressions.Regex.Replace(str, @"\s+", replacedString ?? "");
        }

    }
}
