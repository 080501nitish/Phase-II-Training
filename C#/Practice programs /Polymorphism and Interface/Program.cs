using Abstraction;

/*BankDetails bankDetails = new(12345, 987654321987, 10000, "Nitish", "Inactive");
int choice;
do
{
    Console.WriteLine("Enter \n 1.custid \n 2.accno \n 3.name \n 4.exit");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            int custid=Convert.ToInt32(Console.ReadLine());
            bankDetails.FetchAccountDetails(custid);
            break;
        case 2:
            long accno=Convert.ToInt64(Console.ReadLine());
            bankDetails.FetchAccountDetails(accno);
            break;
         case 3:
            string name=Console.ReadLine();
            bankDetails.FetchAccountDetails(name);  
            break;
          case 4:
            break;

            default:
            Console.WriteLine("Invalid choice");
            break;
    }
} while (choice!=4);*/

IAnimal myPet1 = new MyPetsWithInterface(2, 2, 4, "Dog");
MyPetsWithInterface myPet2 = new(2, 2, 4, "Cat");


/*new MyPetsWithInterface(2,2,4,"DOG").Sleep();*/





/*MyPets myPets1 = new(2, 2, 4, "Dog");
MyPets myPets2 = new(2, 2, 4, "Cat");

Animal.Eat();
Animal.Sleep();

myPets1.AboutMe();
myPets1.Sound();

myPets2.AboutMe();
myPets2.Sound();*/


