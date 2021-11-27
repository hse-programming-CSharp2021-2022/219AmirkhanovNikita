using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Dwarf : Creature
    {
        private int _strength;
        public int Strength
        {
            get => _strength;
            set
            {
                if (value < 1 || value > 20)
                {
                    var rnd = new Random();
                    _strength = rnd.Next(1, 21);
                }
                else
                    _strength = value;
            }
        }
        public Dwarf(string name, int speed, int strength) : base(name, speed)
        {
            Strength = strength;
        }

        public override string Run()
        {
            return $"{base.Run()} My strength is {Strength}";
        }

        public void MakeNewStaff()
        {
            Console.WriteLine("Ivecreatednewstaff");
        }
    }
}
