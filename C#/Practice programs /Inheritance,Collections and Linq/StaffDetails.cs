using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProg
{
    internal class StaffDetails : College
    {
        private int rno;
        private string? name, address;

        public StaffDetails(string? collegeName, string? collegeaddress, int rno, string? name, string? address): base(collegeName,collegeaddress)
        {
            this.rno = rno;
            this.name = name;
            this.address = address; 
        }

        public int Rno { get => rno; set => rno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }

        public  override void DisplayCollegeDetails()
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(Address);
        }
    }
}
