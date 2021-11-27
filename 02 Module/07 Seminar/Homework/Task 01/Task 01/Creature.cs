using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Creature
    {
        public string Name { get; private set; }
        public int Speed { get; private set; }

        virtual public string Run()
        {
            return $"I am running with a speed of {Speed}.";
        }

        public override string ToString()
        {
            return $"{Run()} My name is {Name}";
        }

        public Creature(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
