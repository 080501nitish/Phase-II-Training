using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProg
{
    internal class StudentDetails
    {
        private int rno;
        private string? name,address;

        public StudentDetails(int rno, string? name, string? address)
        {
            this.rno = rno;
            this.name = name;
            this.address = address;
        }

        public int Rno { get => rno; set => rno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
    }
}
