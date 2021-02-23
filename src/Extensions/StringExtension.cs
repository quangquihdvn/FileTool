using System;
using System.Globalization;

namespace FileSplitTool.Extensions
{
    public static class StringExtension
    {
        public static bool IsValidNumber(this string input)
        {
            return int.TryParse(input, out _);
        }

        public static bool IsValidLongNumber(this string input)
        {
            return long.TryParse(input, out _);
        }

        public static bool IsValidDate(this string value)
        {
            return DateTime.TryParseExact(value, "MM/dd", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out _);
        }
    }
}
