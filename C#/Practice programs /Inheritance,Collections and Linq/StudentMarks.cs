using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProg
{
    internal class StudentMarks : StudentDetails
    {
        private int m1;
        private int m2;
        private int m3;

        public StudentMarks(int rno, string name,string address ,int m1, int m2, int m3) : base (rno,name,address) 
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public int M1 { get => m1; set => m1 = value; }
        public int M2 { get => m2; set => m2 = value; }
        public int M3 { get => m3; set => m3 = value; }

        public int CalculateTotal()
        {
            return M1 + M2 + M3;
        }

        public double CalculateAverage()
        {
            return (M1 + M2 + M3) / 3;
        }
    }
}
