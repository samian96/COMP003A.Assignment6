using System.Xml.Serialization;

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

                        Console.WriteLine("");

                        book2.DisplayMessage();

                        Console.WriteLine("");

                        book3.DisplayMessage();

                        Console.WriteLine("");

                        break;

                    case "2":
                        Console.WriteLine("Which Item would you like to update?");

                        string user2 = Console.ReadLine()?.Trim().ToLower();

                        if (user2 == "1")
                        {
                            Console.WriteLine($"\n {book1.Book} is currently {(book1.Instock ? "Available" : "Unavailable")}");
                            Console.Write("Update aivalability? yes/no: ");
                            string user3 = Console.ReadLine()?.Trim().ToLower();
                            if (user3 == "yes" || user == "y")
                            {
                                book1.Instock = true;
                                Console.WriteLine("Availability Updated.");
                            }
                            else if (user == "no" || user == "n")
                            {
                                book1.Instock = false;
                                Console.WriteLine("Availability updated");
                            }
                            else
                            {
                                Console.WriteLine("Cancelled update.");
                            }
                        }
                        

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
