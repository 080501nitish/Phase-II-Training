using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class MyPets : Animal
    {
        private string? name = string.Empty;
        public MyPets(int eyes, int ears, int legs, string name) : base(eyes, ears, legs)
        {
            Name = name;
        }
        public string? Name { get => name; set => name = value; }

        public override void Sound()
        {
            Console.WriteLine(Name);
            if(Name.ToLower().Equals("dog"))
            {
                Console.WriteLine("Bow Bow");
            }
            else if(Name.ToLower().Equals("cat"))
             {
                Console.WriteLine("mewo meow");
            }
        }
    }
}
