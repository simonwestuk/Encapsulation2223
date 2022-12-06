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

        public Garage(string name, string address)
        {
            Name = name;
            Address = address;
            Bookings = new List<Booking>();
        }
    }
}
