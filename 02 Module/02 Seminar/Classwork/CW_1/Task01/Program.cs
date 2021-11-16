using System;

namespace Task01
{
    class MyComplex
    {
        public double re, im;
        public MyComplex(double xre, double xim)
        { 
            re = xre; 
            im = xim; 
        }
        public static MyComplex operator ++(MyComplex mc) => new MyComplex(mc.re + 1, mc.im + 1);

        public static MyComplex operator --(MyComplex mc) => new MyComplex(mc.re - 1, mc.im - 1);

        public double Mod() => Math.Abs(re * re + im * im);

        static public bool operator true(MyComplex f) => f.Mod() > 1.0;

        static public bool operator false(MyComplex f) => f.Mod() <= 1.0;

        public static MyComplex operator +(MyComplex c1, MyComplex c2) => new MyComplex(c1.re + c2.re, c1.im  + c2.im);

        public static MyComplex operator -(MyComplex c1, MyComplex c2) => new MyComplex(c1.re - c2.re, c1.im - c2.im);

        public static MyComplex operator *(MyComplex c1, MyComplex c2) => new MyComplex(c1.re * c2.re - c1.im * c2.im, c1.im * c2.re + c1.re * c2.im);

        public static MyComplex operator /(MyComplex c1, MyComplex c2) => new MyComplex((c1.re * c2.re + c1.im * c2.im)/c2.re*c2.re+c2.im*c2.im, (c1.im*c2.re-c1.re*c2.im)/c2.re*c2.re+c2.im*c2.im);

        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyComplex(1f, 2f);
            var c2 = new MyComplex(3f, 4f);

            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
        }
    }
}
