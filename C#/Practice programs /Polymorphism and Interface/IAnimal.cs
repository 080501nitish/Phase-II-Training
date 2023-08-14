using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal interface IAnimal
    {
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }

    public void Eat();
        

        public void Sound(); 
    }
}
