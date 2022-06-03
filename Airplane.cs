using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    internal class Airplane : Vehicle
    {
        public uint Wings { get; set; }
        public Airplane(string regnum, string brand, string name, string color, uint wings) : base(regnum, brand, name, color)
        {
            Wings = wings;
        }
        public override string ToString()
        { 
            return base.ToString() + "Wings" + Wings; 
        }

    }
}   

