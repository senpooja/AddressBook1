using AddressBook;

Console.WriteLine("====Welcome to Address Book Program====");
AddressBookEntry addressBook = new AddressBookEntry(1);
Contact newContact = AddressBookEntry.CreateContact();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Address book options:\n1:To Add New Entry.\n2:TO Leave.\n");
Console.Write("Option: ");
Console.ResetColor();
string Instruction = Console.ReadLine();
while (true)
{
    if (Instruction.ToLower() == "2")//Checking For Option
    {
        Console.WriteLine("GoodBye!");
        break;
    }
    else if (Instruction.ToLower() == "1")//Checking For Option
    {
        addressBook.AddNewContact();
    }
    else
    {
        Console.WriteLine("Invalid Input!");
    }
}
Console.WriteLine("=========================================================================");