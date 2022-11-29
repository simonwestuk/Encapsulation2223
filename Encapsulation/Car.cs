using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Car : Vehicle
    {
        public Car(string registration, string colour, string make, string model, int noOfWheels)
        : base(registration, colour, make, model, noOfWheels)
        {

        }
    }
}
