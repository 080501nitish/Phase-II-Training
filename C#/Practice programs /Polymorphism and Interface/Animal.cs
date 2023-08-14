using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Animal
    {
        private int eyes, ears, legs;

        public Animal(int eyes, int ears, int legs)
        {
            this.eyes = eyes;
            this.ears = ears;
            this.legs = legs;
        }

        public int Eyes { get => eyes; set => eyes = value; }
        public int Ears { get => ears; set => ears = value; }
        public int Legs { get => legs; set => legs = value; }

        public static void Sleep ()
        {
            Console.WriteLine("Sleeping zzzzzzz");
        }

        public static void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void AboutMe()
        {
            Console.WriteLine($"I have {Eyes} eyes {Ears} "+ $"{ Legs} legs");

        }

        public abstract void Sound();
        

        
    }
}
