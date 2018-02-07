using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            Car Car1 = new Car("Nikolai", "Model S", 2017, 54999.90);
            Car Car2 = new Car("Fourd", "Escapade", 2017, 31999.90);
            Car Car3 = new Car("Chewie", "Vette", 2017, 44989.95);
            Car Car4 = new Used_Car("Hyonda", "Prior", 2015, 14795.50, 35987.6);
            Car Car5 = new Used_Car("GC", "Chirpus", 2013, 8500.00, 12345.0);
            Car Car6 = new Used_Car("GC", "Witherell", 2016, 14450.00, 3500.3);

            List<Car> ForSale = new List<Car> { Car1, Car2, Car3, Car4, Car5, Car6 };
            while (run == true)
            {
                int count = 0;
                foreach (Car cars in ForSale)
                {
                    Console.Write(count++);
                    Console.WriteLine(cars.PrintCar());
                }
                Console.WriteLine(count + "      Quit");

                Console.WriteLine("Which car would you like?  1,2,3,etc");
                string input = Console.ReadLine();
                int x;

                if (int.TryParse(input, out x) && x >= 0 && x <= ForSale.Count)
                {
                    Console.WriteLine(ForSale[x].PrintCar());

                    Console.WriteLine("Would you like to buy this car? (y/n)");
                    string input2 = Console.ReadLine();
                    input2.ToLower();

                    if (input2 == "y")
                    {
                        ForSale.RemoveAt(x);
                        Console.WriteLine("Exellent!  Thank You for your Purchase");
                    }
                    else if (input2 == "n")
                    {
                        run = false;
                        Console.WriteLine("Good Bye");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}
