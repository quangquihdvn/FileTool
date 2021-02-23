namespace FileSplitTool.Extensions
{
    public static class IntegerExtension
    {
        public static string ConvertErrorCode(this int value)
        {
            return value.ToString("00");
        }
    }
}
