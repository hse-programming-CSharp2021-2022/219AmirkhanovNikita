using System;

namespace Task02
{
    class Program
    {

        public static void FunctionFor()
        {
            Console.WriteLine("for: ");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i * i } ");
            }
            Console.WriteLine();
        }

        public static void FunctionWhile()
        {
            Console.WriteLine("while: ");
            int i = 1;
            while (i < 11)
            {
                Console.Write($"{i * i } ");
                i++;
            }
            Console.WriteLine();
        }

        public static void FunctionDoWhile()
        {
            Console.WriteLine("do while: ");
            int i = 1;
            do
            {
                Console.Write($"{i * i } ");
                i++;
            } while (i < 11);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            FunctionFor();
            FunctionWhile();
            FunctionDoWhile();
        }
    }
}
