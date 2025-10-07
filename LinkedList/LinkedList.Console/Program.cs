using LinkedList.Core;

var list = new SimplyLinkedList<string>();
var opc = string.Empty;
do
{
    opc = Menu();
    switch (opc)
    {
        case "0":
            Console.WriteLine("Exiting...");
            break;
        case "1":
            Console.Write("Enter value to insert at beginning: ");
            list.InsrtAtBeginning(Console.ReadLine()!);
            break;
        case "2":
            Console.Write("Enter value to insert at end: ");
            list.InsrtAtEnd(Console.ReadLine()!);
            break;
        case "3":
            list.PrintList();
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
    } while (opc != "0");

string Menu()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1. Insert at Beginning");
    Console.WriteLine("2. Insert at End");
    Console.WriteLine("3. Print List");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
    return Console.ReadLine()!;
}