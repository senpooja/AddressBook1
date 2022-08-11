using AddressBook;

Console.WriteLine("==========Welcome To Address Book Program==========");
Console.Write("Select Number:\n1)AddContacts\n2)EditContact\n3)Update\n4)AllDetails\n");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        EditEntry.NewContact();
        break;
    case 2:
        EditEntry.Update();
        break;
    case 3: 
        EditEntry.ListAllContact();
        break;
    default:
        Console.Write("Please Select Correct Number");
        break;
}