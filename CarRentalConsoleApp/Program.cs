using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Rent a car");
                Console.WriteLine("2. Return a car");
                Console.WriteLine("3. Customers");
                Console.WriteLine("4. Cars");
                Console.WriteLine("5. Extit");

                string menuOptionChoice = Console.ReadLine();

                switch (menuOptionChoice)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        running = false;
                        break;
                }
            }
        }
    }
}
