using System;

namespace Task01
{
    class Program
    {
        static bool Shift(ref char ch)
        {
            int code = (int)ch;
            if (code < 97 || code > 122) return false;
            code += 4;
            code = code > 122 ? code - 122 + 96 : code;
            ch = (char)code;
            return true;
        }
        static void Main(string[] args)
        {
            char a = Console.ReadKey().KeyChar;
            if (Shift(ref a))
                Console.WriteLine();
                Console.WriteLine(a);
        }
    }
}
