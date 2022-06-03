using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    public class Boat : Vehicle
    {
     public double Length { get; set; }
        public Boat(string regnum, string brand, string name, string color, double lenght) : base(regnum, brand, name, color)
        {Length = lenght;}
        public override string ToString()
        {
            return base.ToString() + "längden"+ Length;
        }
    } }
