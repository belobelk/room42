using System;
using System.Web;

namespace Infrastructure.Helpers
{
    public static class KeyGenerator
    {
        public static string Generate()
        {
            return Generate(Guid.NewGuid().ToString("D").Substring(24));
        }

        public static string Generate(string input)
        {
            return HttpUtility.UrlEncode(input.Replace(" ", "_").Replace("-", "_").Replace("&", "and"));
        }
    }
}
