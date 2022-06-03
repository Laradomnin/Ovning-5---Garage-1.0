using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
 
    public abstract class Vehicle
    {
        public string RegNum { get; set; }
        public string? Brand { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public Vehicle(string regnum, string brand, string name, string color)
        {
            RegNum = regnum;
            Brand = brand;
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            return "Registreringsnummer :" + RegNum +
                    "\n Märke :" + Brand +
                    "\n Namn:" + Name +
                    "\n Färg:" + Color;
        }

        
    }
}
