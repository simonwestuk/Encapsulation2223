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
            Console.Clear();
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
            string manage = Prompt.Select("Select your option", new[] { "Add New Driver", "View Drivers", "Delete Driver" });

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

                case "View Drivers":
                    Console.Clear();
                    foreach (var item in garage.Drivers)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("--------------------");
                    }
                    Console.ReadLine();
                    Console.WriteLine("Prease any key to return to main menu.");
                    MainMenu();
                    break;

                case "Delete Driver":
                    Console.Clear();
                    string licenceNum = Prompt.Input<string>("Enter licence number:");
                    Driver? current = garage.GetDriver(licenceNum);

                    if (current != null)
                    {
                        garage.Drivers.Remove(current);
                        Console.WriteLine("Driver removed.");
                    }
                    else
                    {
                        Console.WriteLine("Driver not found.");
                    }

                    Console.ReadLine();
                    Console.WriteLine("Prease any key to return to main menu.");
                    MainMenu();
                    break;

                default:
                    break;
            }

        }

        private static void manageCars()
        {
            Console.WriteLine($"Cars Manager");
            Console.WriteLine("---------------");
            string manage = Prompt.Select("Select your option", new[] { "Add New Car", "View Cars", "Delete Car" });

            switch (manage)
            {
                case "Add New Car":
                    string licenceNum = Prompt.Input<string>("Enter licence number:");
                    Driver? driver = garage.GetDriver(licenceNum);

                    if (driver != null)
                    {

                        string reg = Prompt.Input<string>("Enter registration number:");
                        string colour = Prompt.Input<string>("Enter colour:");
                        string make = Prompt.Input<string>("Enter make:");
                        string model = Prompt.Input<string>("Enter model:");

                        Car car = new Car(reg, colour, make, model, driver);
                        garage.Cars.Add(car);
                    }
                    else
                    {
                        Console.WriteLine("Car not found.");
                    }

                    Console.ReadLine();
                    Console.WriteLine("Prease any key to return to main menu.");
                    MainMenu();
                    break;


                case "View Cars":
                    Console.Clear();
                    foreach (var item in garage.Cars)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("--------------------");
                    }
                    Console.ReadLine();
                    Console.WriteLine("Prease any key to return to main menu.");
                    MainMenu();
                    break;


                case "Delete Car":
                    Console.Clear();
                    string registraionNum = Prompt.Input<string>("Enter registration number:");
                    Car? currentCar = garage.GetCar(registraionNum);

                    if (currentCar != null)
                    {
                        garage.Cars.Remove(currentCar);
                        Console.WriteLine("Car removed.");
                    }
                    else
                    {
                        Console.WriteLine("Car not found.");
                    }

                    Console.ReadLine();
                    Console.WriteLine("Prease any key to return to main menu.");
                    MainMenu();
                    break;

                default:
                    break;

            }

        }
    }
}

