using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;

namespace Encapsulation
{
    internal static class CLI
    {
        public static Garage garage { get; set; }
        public static void MainMenu()
        {
            Console.WriteLine($"Welcome to the { garage.Name }!");
            Console.WriteLine("--------------------------------");

            string manage = Prompt.Select("Select your option", new[] { "Manage Bookings", "Manage Drivers", "Manage Cars" });

            switch (manage)
            {
                case "Manage Bookings":
                    manageBookings();
                    break;
                case "Manage Drivers":
                    managerDrivers();
                    break;
                case "Manage Cars":
                    manageCars();
                    break;
                default:
                    break;
            }

        }

        private static void manageBookings()
        {
            Console.WriteLine($"Bookings Manager");
            Console.WriteLine("---------------");
        }


        private static void managerDrivers()
        {
            Console.WriteLine($"Driver Manager");
            Console.WriteLine("---------------");
            string manage = Prompt.Select("Select your option", new[] { "Add New Driver", "View Driver", "Delete Driver" });

            switch (manage)
            {
                case "Add New Driver":

                    string licence = Prompt.Input<string>("Enter licence number:");
                    string name = Prompt.Input<string>("Enter driver name:");
                    int age = Prompt.Input<int>("Enter age:");
                    string address = Prompt.Input<string>("Enter address:");

                    Driver driver = new Driver(licence, name, age, address);

                    garage.Drivers.Add(driver);

                    Console.WriteLine($"Driver added:\n{driver}");

                    MainMenu();

                    break;
                case "View Driver":
                    
                    break;
                case "Delete Driver":
                    
                    break;
                default:
                    break;
            }

        }

        private static void manageCars()
        {
            Console.WriteLine($"Cars Manager");
            Console.WriteLine("---------------");
        }
    }
}

