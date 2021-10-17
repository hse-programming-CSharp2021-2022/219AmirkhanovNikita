using System;
using System.Text.RegularExpressions;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            var re = new Regex(@"[a-zA-Z]+a\b");
            string s = Console.ReadLine();
            var matches = re.Matches(s);
            foreach (Match match in matches)
                Console.WriteLine(match.Value);
        }
    }
}
