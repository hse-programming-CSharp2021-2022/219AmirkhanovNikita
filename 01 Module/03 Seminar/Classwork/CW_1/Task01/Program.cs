using System;

namespace Task01
{
    class Program
    {

        public static bool b(int n) => Convert.ToBoolean(n);
        public static int c(bool n) => Convert.ToInt32(n);

        public static bool Function1(bool p, bool q) => !(p & q) & !(p | !q);

        public static void Function2(bool p, bool q, out bool r)
        {
            r = !(p & q) & !(p | !q);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"{i} {j} => {c(Function1(b(i), b(j)))}");
                }
            }
        }
    }
}
