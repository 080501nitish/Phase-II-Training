using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProg
{
    internal class College
    {
        private string? collegeName, collegeaddress;

        public College(string? collegeName, string? collegeaddress)
        {
            this.collegeName = collegeName;
            this.collegeaddress = collegeaddress;
        }

        public string? CollegeName { get => collegeName; set => collegeName = value; }
        public string? Collegeaddress { get => collegeaddress; set => collegeaddress = value; }

        public void DisplayCollegeDetails()
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(Collegeaddress);
        }
    }
}
