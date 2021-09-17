using System;

namespace Task03
{
    class Program
    {
        static int Count(int n) => n == 0 ? 0 : 1 + Count(n / 10);
       
        static void Main(string[] args)
        {
            Console.WriteLine(Count(123));
        }
    }
}
