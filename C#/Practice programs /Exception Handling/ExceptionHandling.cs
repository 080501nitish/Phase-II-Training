using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExceptionHandling
    {
        private int num1, num2, res;
        private int age;
        

        public ExceptionHandling(int num1, int num2, int res,int age)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            this.Res = res;
            this.Age = age;
            
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Res { get => res; set => res = value; }
        public int Age { get => age; set => age = value; }

        /*    public int[] Num3 { get => num3; set => num3 = value; }*/

        public int Add()
        {
            Res = Num1 + Num2;
            return Res;

        }
        public int Div()
        {
            if (Num2 != 0)
            {
                Res = Num1 / Num2;
            }
            else
            {
                throw new DivException("Trying to div by 0");
            }
                return Res;
        }

        public void CheckAge()
        {
            if (Age < 18)
            {
                throw new AgeException();
            }
            else
            {
                Console.WriteLine("OK");
            }
        }

    }
}
