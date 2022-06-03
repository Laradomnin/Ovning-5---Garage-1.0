using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    internal class GarageHandler
    {
        private Garage<Vehicle> garage;

        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }



        public void SeedData()
        {
            Park(new Airplane("AIR111", "Boeing", "787", "White", 40));
            Park(new Airplane("AIR222", "Boeing", "787", "White", 40));
            Park(new Airplane("AIR333", "Boeing", "787", "White", 40));
            Park(new Boat("BBB45", "Sandström", "Cabinbåt", "Blå", 6));
        }

        public void Park(Vehicle vehicle)
        {
            if (garage.Park(vehicle))
            {
                Console.WriteLine($"Successfully parked vehicle: {vehicle.RegNum}");
            }
            else
            {
                Console.WriteLine($"Unable to park vehicle: {vehicle.RegNum}. Garage was full.");
            }
        }

        public void Unpark(string regnr)
        {
            
                if (garage.Unpark(regnr))
                {
                    Console.WriteLine($"Successfully unparked vehicle: {regnr}.");
                }
                else
                {
                    Console.WriteLine($"Unable to unpark vehicle: {regnr}.");
                }
           
        }
            
        public void PrintAllVehicles()
        {
            foreach (var vehicle in garage)
            {
                Console.WriteLine(vehicle.ToString());
              
            }
        // var result = garage.Where(v => v.Color == "Red");
        }


        public void SearchByColorAndPrint(string color)
        {
          
            var result = garage.Where(v => v.Color.ToLower().StartsWith(color.ToLower()));

            foreach (var vehicle in result)
            {
                Console.WriteLine(vehicle.ToString());
            }
        
        }
    }
}
