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
                            Console.Write("Update aivalability? check in(1)/check-out(2): ");
                            string user3 = Console.ReadLine()?.Trim().ToLower();
                            if (user3 == "1")
                            {
                                book1.Instock = true;
                                Console.WriteLine("Availability Updated.");
                            }
                            else if (user3 == "2")
                            {
                                book1.Instock = false;
                                Console.WriteLine("Availability updated");
                            }
                            else
                            {
                                Console.WriteLine("Cancelled update.");
                            }
                        } else if (user2 == "2")
                        {
                            Console.WriteLine($"\n {book2.Book} is currently {(book2.Instock ? "Available" : "Unavailable")}");
                            Console.Write("Update aivalability? check in(1)/check-out(2): ");
                            string user3 = Console.ReadLine()?.Trim().ToLower();
                            if (user3 == "1")
                            {
                                book2.Instock = true;
                                Console.WriteLine("Availability Updated.");
                            }
                            else if (user3 == "2")
                            {
                                book2.Instock = false;
                                Console.WriteLine("Availability updated");
                            }
                            else
                            {
                                Console.WriteLine("Cancelled update.");
                            }
                        } else if (user2 == "3")
                        {
                            Console.WriteLine($"\n {book3.Book} is currently {(book3.Instock ? "Available" : "Unavailable")}");
                            Console.Write("Update aivalability? check in(1)/check-out(2): ");
                            string user3 = Console.ReadLine()?.Trim().ToLower();
                            if (user3 == "1")
                            {
                                book3.Instock = true;
                                Console.WriteLine("Availability Updated.");
                            }
                            else if (user3 == "2")
                            {
                                book3.Instock = false;
                                Console.WriteLine("Availability updated");
                            }
                            else
                            {
                                Console.WriteLine("Cancelled update.");
                            }
                        } else
                        {
                            Console.WriteLine("invalid choice.");
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
