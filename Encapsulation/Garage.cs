using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Garage
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Car> Cars { get; set; }

        public Garage(string name, string address)
        {
            Name = name;
            Address = address;
            Bookings = new List<Booking>();
            Drivers = new List<Driver>();
            Cars = new List<Car>();
        }

        public Driver? GetDriver(string licence)
        {
            foreach (var driver in Drivers)
            {
                if (driver.LicenceNumber == licence)
                {
                    return driver;

                }
            }

            return null;

        } 
        
        public Car? GetCar(string reg)
        {
            foreach (var car in Cars)
            {
                if (car.Registration == reg)
                {
                    return car;

                }
            }

            return null;

        }
    }
}
