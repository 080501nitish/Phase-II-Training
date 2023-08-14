using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class MyPetsWithInterface : IAnimal
    {
        private int eyes, ears, legs;
        private string? name=string.Empty;

        public MyPetsWithInterface(int eyes, int ears, int legs, string? name)
        {
            this.eyes = eyes;
            this.ears = ears;
            this.legs = legs;
            this.Name = name;
        }

        public int Eyes { get => eyes; set => eyes = value; }
        public int Ears { get => ears; set => ears = value; }
        public int Legs { get => legs; set => legs = value; }
        public string? Name { get => name; set => name = value; }

        public void AboutMe()
        {
            Console.WriteLine($"I have {Eyes} eyes {Ears} " + $"{Legs} legs");

        }

        public void Sound()
        {
            Console.WriteLine(Name);
            if (Name.ToLower().Equals("dog"))
            {
                Console.WriteLine("Bow Bow");
            }
            else if (Name.ToLower().Equals("cat"))
            {
                Console.WriteLine("mewo meow");
            }
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping zzzzzzz");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }


}
}

