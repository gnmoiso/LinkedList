using Doubly_List;

var list = new DoublyLinkedList<string>();
var opc = "0";

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
            list.InsertAtBeginning(Console.ReadLine()!);
            break;

        case "2":
            Console.Write("Enter value to insert at end: ");
            list.InsertAtEnd(Console.ReadLine()!);
            break;

        case "3":
            Console.WriteLine("List Forward: ");
            Console.WriteLine(list.GetForward());
            break;

        case "4":
            Console.WriteLine("List Backward: ");
            Console.WriteLine(list.GetBackward());
            break;

        case "5":
            Console.Write("Enter value to remove: ");
            var valueToRemove = Console.ReadLine();
            if (valueToRemove == string.Empty)
            {
                Console.WriteLine($"Invalid value {valueToRemove}");
                break;
            }
            list.Remove(valueToRemove!);
            Console.WriteLine($"Value {valueToRemove} removed from the list");
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}
while (opc != "0");

string Menu()
{
    Console.WriteLine();
    Console.WriteLine("1. Insert at Beginning");
    Console.WriteLine("2. Insert at End");
    Console.WriteLine("3. Show List Forward");
    Console.WriteLine("4. Show List Bacward");
    Console.WriteLine("5. Remove");
    Console.WriteLine("0. Exit");
    Console.WriteLine();
    Console.Write("Choose an option: ");
    Console.WriteLine();
    return Console.ReadLine()!;
}