using Bank;
using System.Xml.Serialization;

Console.WriteLine("Enter your Account Number");
int AccountNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Account Holder Name");
string? AccountHolderName = Console.ReadLine();
BankAccount Account = new BankAccount(AccountNumber,AccountHolderName);
int choice;
do
{
    Console.WriteLine("\nEnter your Choice \n 1.Deposit \n 2.Withdraw \n 3.CheckBalance \n 4.End\n");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Account.deposit();
            break;
        case 2:
            Account.withdraw();
            break;
        case 3:
            Account.PrintBalance(); 
            break;
        case 4:
            break;
        default:
            Console.WriteLine("\nYour choice is wrong\nPlease try again...\n");
            break;
    }
}while(choice!=4);