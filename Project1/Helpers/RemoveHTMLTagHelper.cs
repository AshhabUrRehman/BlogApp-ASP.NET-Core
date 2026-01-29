using System.Text.RegularExpressions;

namespace Project1.Helpers
{
    public static class RemoveHtmlTagHelper
    {
        public static string RemoveHtmlTags(string input)
        {
            //return Regex.Replace(input,"<.*?| &.*?;>",string.Empty);
            return Regex.Replace(input, "<[^>]*>|&[a-zA-Z]+;",string.Empty);
        }
    }
}
