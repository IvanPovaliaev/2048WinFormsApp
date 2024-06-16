namespace _2048.Common
{
    public static class Extensions
    {
        public static string NullIfEmpty(this string value)
        {
            if (value == string.Empty) return null;
            return value;
        }
    }
}
