using System;

namespace CertificationManager.Shared.Extensions
{
    public static class EnumExtension
    {

        public static bool TrySafeParse<TEnum>(string enumName, out TEnum result) where TEnum : struct
        {
            result = default(TEnum);
            var isValid = Enum.TryParse(enumName.Replace("-", ""), true, out TEnum objParsed);
            if (isValid)
                result = (TEnum)objParsed;
            return isValid;
        }
    }
}
