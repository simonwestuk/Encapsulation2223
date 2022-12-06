using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Motorbike : Vehicle
    {
        public Motorbike(string registration, string colour, string make, string model, Driver driver)
      : base(registration, colour, make, model, 2, driver)
        {

        }
    }
}
