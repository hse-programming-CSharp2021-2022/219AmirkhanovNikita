using System;
using System.Text.RegularExpressions;


namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var re = new Regex(@"\b[a-zA-Z]{4}\b");
            var matches = re.Matches(s);
            foreach(Match match in matches)
                Console.WriteLine(match.Value);
        }
    }
}
