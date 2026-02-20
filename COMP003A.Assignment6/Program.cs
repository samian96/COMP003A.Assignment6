namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("The Call of Cthulu", 39, false, "");

            bool running = true;

            while (running)
            {
                Console.WriteLine("Library Menu.\n");

                Console.WriteLine("1. Display All:\n2. Update One Item:\n3. Exit: ");

                Console.Write("\n Please choose an option: ");

                string user = Console.ReadLine();
            }



        }
    }
}
