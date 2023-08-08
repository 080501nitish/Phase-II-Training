using Bank_2;

Library library = new Library();
int choice;
do
{
    Console.WriteLine("Enter your choice");
    Console.WriteLine("1.Available Books \n 2.Borrow Book \n 3.Return Book \n 4.Exit");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            library.DisplayAvailableBooks(); break;
        case 2:
            Console.WriteLine("Enter Book Title to borrow\n");
            string? title = Console.ReadLine();
            library.BorrowBook(title); break;
        case 3:
            Console.WriteLine("Enter Book Title to return\n");
            string? rtitle = Console.ReadLine();
            library.ReturnBook(rtitle); break;
        case 4:
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
} while (choice != 4);