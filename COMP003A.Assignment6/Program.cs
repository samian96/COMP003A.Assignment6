namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bookitem book1 = new bookitem("The Call of Cthulu", 39, false, "");

            Console.WriteLine("Library Menu.\n");

            Console.WriteLine("1. Display All:\n2. Update One Item:\n3. Exit: ");

            BookItem.DisplayMessage()

            string user = Console.ReadLine();


        }
    }
}
