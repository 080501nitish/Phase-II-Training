using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProg
{
    internal class StudentGrade : StudentMarks
    {
        public StudentGrade(int rno, string name, string address, int m1, int m2, int m3) : base(rno, name, address, m1, m2, m3)
        {
        }

        public char CalculateGrade()
        {
            double average = CalculateAverage();
            if (average >= 90)
            {
                return 'A';
            }
            else if(average <90 && average >= 70)
            {
                return 'B';
            }
            else
            {
                return 'C';
            }
        }
    }
}
