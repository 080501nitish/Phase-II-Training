using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AgeException : Exception
    {
        public AgeException() : base("Invalid age")
        { 
        }

    }
    public class DivException : Exception
    {
        public DivException(String msg) : base()
        {
        }

    }
}
