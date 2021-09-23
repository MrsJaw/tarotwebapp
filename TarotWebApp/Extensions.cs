using System.Text.RegularExpressions;

namespace TarotWebApp
{
    public static class Extensions
    {
        public static string ToTitle(this string s)
        {
            if (s == null)
                return null;
            return Regex.Replace(s, "([a-z])([A-Z])", "$1 $2").Trim();
        }
    }
}
