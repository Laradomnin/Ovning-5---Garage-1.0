using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    internal class Car:Vehicle
    {
            public string Fuel { get; set; }
            public Car (string regnum, string brand, string name, string color, string fuel) : base(regnum, brand, name, color)
            {
              Fuel = fuel;
            }
            public override string ToString()
            {
                return base.ToString() + "Bränsle: " + Fuel;
            }

        }
    }


