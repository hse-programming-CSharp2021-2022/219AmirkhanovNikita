using System;
using System.Text;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] aa = { 'a', 'e', 'i', 'o', 'u', 'y' };
            string s = Console.ReadLine();
            string[] a = s.Split(';');
            foreach (var item in a)
            {
                StringBuilder sb = new StringBuilder();
                string f = item.Trim();
                string[] b = f.Split();
                foreach (var word in b)
                {
                    int p = word.ToLower().IndexOfAny(aa);
                    
                    char up = word.ToUpper()[0];
                    sb.Append(up);
                    sb.Append(word.Substring(1, p));
                }
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
