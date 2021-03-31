using System;
using System.Text.RegularExpressions;

namespace Packt.Shared
{
    public static class StringExtantions
    {
        public static bool IsValidPassword(this string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9_-]{8,}$");
        }
    }
}
