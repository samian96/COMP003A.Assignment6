namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookTracker book1 = new BookTracker("The Call of Cthulu", 39, false);

            bool running = true;

            while (running)
            {
                Console.WriteLine("Library Menu.\n");

                Console.WriteLine("1. Display All:\n2. Update One Item:\n3. Exit: ");

                Console.Write("\n Please choose an option: 1-3): ");

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
