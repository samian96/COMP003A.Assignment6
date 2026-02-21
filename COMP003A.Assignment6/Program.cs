namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookTracker book1 = new BookTracker("The Call of Cthulu", 39, false);

            BookTracker book2 = new BookTracker("Dante's Inferno", 700, true);

            BookTracker book3 = new BookTracker("Collection of Edgar Allen Poe", 928, true);

            bool running = true;

            Console.WriteLine("Library Menu.\n");

            Console.WriteLine("1. Display All:\n2. Update One Item:\n3. Exit: ");

            while (running)
            {

                Console.Write("\n Please choose an option: ");

                string user = Console.ReadLine();

                switch (user)
                {
                    case "1":

                        Console.WriteLine("\nLibrary Availability:");
                        book1.DisplayMessage();
                        break;
                    case "2":
                        Console.WriteLine("update: not implemented yet");
                        break;
                    case "3":
                        Console.WriteLine("Goodbye.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }



        }
    }
}
