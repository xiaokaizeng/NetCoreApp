using System;

namespace NetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////“Hello World”应用程序
            //Console.WriteLine("Hello World!");
            //Console.Write("Press any key to continue...");
            //Console.ReadKey(true);

            //改进“Hello World”应用程序
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
