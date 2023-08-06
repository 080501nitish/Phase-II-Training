using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProg
{
    internal class NonTeachingStaff : StaffDetails
    {
        private double basicsalary;
        private readonly int _da, _hra, _cca, _pf;

        public NonTeachingStaff(string? collegeName, string? collegeaddress,int rno, string? name, string? address, double basicsalary, int da, int hra, int cca, int pf) : base(collegeName, collegeaddress,rno, name, address)
        {
            this.basicsalary = basicsalary;
            _da = da;
            _hra = hra;
            _cca = cca;
            _pf = pf;
           
        }

        public double Basicsalary { get => basicsalary; set => basicsalary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public float CalculateSalary()
        {
            float grossSalary = (float)(Basicsalary + (Basicsalary * ((float)Da / 100)) + (Basicsalary * ((float)Hra / 100)) + ((float)Basicsalary * ((float)Cca / 100)) - (Basicsalary * ((float)Pf / 100)));
            return grossSalary;
        }
    }
}
