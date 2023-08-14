using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstraction
{
    internal class BankDetails
    {
        private int c_id;
        private string? name,status;
        private long accno;
        private double balance;

        public BankDetails(int c_id, long accno, double balance,string? name, string? status)
        {
            this.C_id = c_id;
            this.Name = name;
            this.Status = status;
            this.Accno = accno;
            this.Balance = balance;
        }

        public int C_id { get => c_id; set => c_id = value; }
        public string? Name { get => name; set => name = value; }
        public string? Status { get => status; set => status = value; }
        public long Accno { get => accno; set => accno = value; }
        public double Balance { get => balance; set => balance = value; }

       public void FetchAccountDetails(int c_id)
        {
            if(C_id == c_id)
            {
                Console.WriteLine(Accno +" "+ Name +" "+ Status +" " +Balance);
            }
        }
        public void FetchAccountDetails(long accno)
        {
            if (Accno == accno)
            {
                Console.WriteLine(C_id + " " + Name + " " + Status + " " + Balance);
            }
        }
        public void FetchAccountDetails(string name)
        {
            if (Name.Equals(name))
            {
                Console.WriteLine(C_id + " " + Accno + " " + Status + " " + Balance);
            }
        }

    }
}
