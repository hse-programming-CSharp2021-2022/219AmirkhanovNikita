using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Elf : Creature
    {
        public int Age { get; private set; }
        private int azino = 77;

        public Elf(string name, int speed) : base(name, speed)
        {
            var rnd = new Random(0);
            Age = rnd.Next(100, 201);

        }

        public override string Run()
        {
            return $"I am runing with speed of {Speed + Age / azino}";
        }

    }
}
