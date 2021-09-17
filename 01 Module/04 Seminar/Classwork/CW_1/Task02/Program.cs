using System;

namespace Task02
{
    class Program
    {

        static double f(double x) => x * x;

        static double Square(double a, double delta)
        {
            double s = 0;
            int j = 0;
            for (int i = 0; delta*i<=a; i++)
            {
                s += (f(delta * i) + f(delta * (i + 1))) / 2 * delta;
                j = i;
            }
            if (a%delta!=0)
            {
               
                s += (f(j * delta) + f(a)) / 2 * (j * delta - a);
            }
            return s;
        }
        static void Main(string[] args)
        {
            double a, delta;
            bool s = true;
            s &= double.TryParse(Console.ReadLine(), out a);
            s &= double.TryParse(Console.ReadLine(), out delta);
            s &= a >= delta;
            s &= delta > 0;
            if (!s)
                return;
            Console.WriteLine(Square(a, delta));
        }
    }
}
