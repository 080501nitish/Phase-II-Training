using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        private readonly int AccountNumber;
        private string AccountHolderName;
        public static int Balance=0;
        public BankAccount(int AccountNumber,string AccountHolderName)
        {
            this.AccountNumber = AccountNumber;
            AccountHolderName1 = AccountHolderName;
        }
        public string AccountHolderName1 { get => AccountHolderName; set => AccountHolderName = value; }

        public void deposit()
        {
            Console.WriteLine("Enter The Amount to Deposit");
            int Dep_Amount = Convert.ToInt32(Console.ReadLine());
            Balance = Balance + Dep_Amount;
        }

        public void withdraw()
        {
            Console.WriteLine("Enter The Amount to Withdraw");
            int Wit_Amount = Convert.ToInt32(Console.ReadLine());
            if (Wit_Amount <= Balance)
            {
                Balance = Balance - Wit_Amount;
            }
            else
            {
                Console.WriteLine("\n Insufficient Balance \n");
            }
            
        }

        public void PrintBalance()
        {
            Console.WriteLine($"\n Account Number : {AccountNumber} \n Account Holder Name : {AccountHolderName1} \n Balance : {Balance} \n");
        }
    }
}
