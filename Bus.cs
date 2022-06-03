using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    internal class Bus:Vehicle
    {
        public Bus(string regnum, string brand, string name, string color, uint Seats) : base(regnum, brand, name, color)
        {
        }

        public uint Seats { get; set; }
        
       
       

    }
}
