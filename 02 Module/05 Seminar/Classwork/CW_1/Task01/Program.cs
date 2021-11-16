using System;

namespace Task01
{

    abstract class Animal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Animal (string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void AnimalSound();
        public abstract string AnimalInfo();
    }

    class Dog : Animal
    {

        public string Type { get; private set; }
        public bool IsTrained { get; private set; }
        public Dog(string name, int age, string type, bool isTrained) : base(name, age)
        {
            Type = type;
            IsTrained = isTrained;
        }

        public override string AnimalInfo()
        {
            return $"{Name} - {Age} - {IsTrained} - {Type}";
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Bark bark");
        }
    }

    class Cow : Animal
    {

        public int Milk { get; private set; }
        public Cow(string name, int age, int milk) : base(name, age)
        {
            Milk = milk;
        }

        public override string AnimalInfo()
        {
            return $"{Name} - {Age} - {Milk}";
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Mooooo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("dog", 1, "b", true);
            var cow = new Cow("cow", 2, 100);
            Console.WriteLine(dog.AnimalInfo());
            dog.AnimalSound();

            Console.WriteLine(cow.AnimalInfo());
            cow.AnimalSound();
        }
    }
}
