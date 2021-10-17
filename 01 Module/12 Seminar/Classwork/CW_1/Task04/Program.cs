using System;
using System.Text.RegularExpressions;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int maxNum = 0;
            var re = new Regex(@"[\d]+");
            var matches = re.Matches(s);
            foreach (Match match in matches)
                if (match.Value.Length > maxNum)
                    maxNum = match.Value.Length;
            Console.WriteLine(maxNum);
        }
    }
}
