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

        case "4":
            Console.WriteLine("Enter value to search: ");
            var read = Console.ReadLine();
            bool wasFound = list.Contains(read!);
            if (wasFound == true)
            {
                Console.WriteLine($"The Value {read} is found");
            }
            else
            {
                Console.WriteLine($" The Value {read} isn´t found");
            }
            break;

        case "5":
            Console.WriteLine("Enter value to remove: ");
            var valueToRemove = Console.ReadLine();
            if (valueToRemove == null)
            {
                Console.WriteLine("Invalid value");
                break;
            }
            else if (!list.Contains(valueToRemove))
            {
                Console.WriteLine("Value not found in the list");
                break;
            }

            list.Remove(valueToRemove!);
            Console.WriteLine($"Value {valueToRemove} removed from the list");
            break;

        case "6":
            list.Reverse();
            Console.WriteLine("List reversed");
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
    Console.WriteLine("1. Insert at Beginning");
    Console.WriteLine("2. Insert at End");
    Console.WriteLine("3. Print List");
    Console.WriteLine("4. Search for Value");
    Console.WriteLine("5. Remove Value");
    Console.WriteLine("6. Reverse List");
    Console.WriteLine("0. Exit");
    Console.WriteLine();
    Console.Write("Choose an option: ");
    Console.WriteLine();
    return Console.ReadLine()!;
}