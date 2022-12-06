using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Driver
    {
        public string LicenceNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Driver(string licenceNumber, 
                      string name, 
                      int age, 
                      string address)
        {
            LicenceNumber = licenceNumber;
            Name = name;
            Age = age;
            Address = address;
        }

        public override string? ToString()
        {
            return $"Licence: { LicenceNumber }\nDriver Name: { Name }\nAge: { Age }\nAddress: { Address }";
        }
    }
}
