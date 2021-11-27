using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cr = new Creature[n];
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                var x = r.Next(1, 11);
                var name = "frewfwf" + r.Next().ToString();
                var sped = r.Next(10, 18);
                var strength = r.Next(-50, 51);
                if (x <= 2)
                {
                    cr[i] = new Creature(name, sped);
                }
                else if (x <= 6)
                {
                    cr[i] = new Dwarf(name, sped, strength);
                }
                else
                {
                    cr[i] = new Elf(name, sped);
                }
                Console.WriteLine(cr[i]);
            }
        }
    }
}
