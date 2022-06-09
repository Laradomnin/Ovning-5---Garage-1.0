using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    public class GarageHandler
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
            Park(new Bus("ABC142", "Scania", "Skolbuss", "Röd", 20));
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
       
        }


        
        public void SearchByColorAndPrint(string color)
        {
          
            var result = garage.Where(v => v.Color.ToLower().StartsWith(color.ToLower()));

            foreach (var vehicle in result)
            {
                Console.WriteLine(vehicle.ToString());
            }
        
        }
        public void SearchByType(string searchType)
        {
        // Car => Car

        // car => Car
        // bUS => Bus

        // ca => Car
        // TRUC => Truck
        // b => boat, bus
        
           // var result = garage.Where(v => v.GetType().Name.ToLower() == searchType.ToLower());
            var result = garage.Where(v => v.GetType().Name.ToLower().StartsWith(searchType));

            foreach (var vehicle in result)
            {
                Console.WriteLine(vehicle.ToString());
            }
           
        }

        public void CountTypes()
        {
            // dumma sättet
            int airplaneCount = 0;
            int boatCount = 0;
            int busCount = 0;
            int carCount = 0;

            foreach (var vehicle in garage)
            {
                if(vehicle.GetType().Name == "Car")
                {
                    carCount++;
                }
                if (vehicle.GetType().Name == "Boat")
                {
                    boatCount++;
                }
                if (vehicle.GetType().Name == "Bus")
                {
                    busCount++;
                }
                if (vehicle.GetType().Name == "Airplane")
                {
                    airplaneCount++;
                }
            }

            Console.WriteLine($"Airplanes: {airplaneCount}");
            Console.WriteLine($"Buses: {busCount}");
            Console.WriteLine($"Boats: {boatCount}");
            Console.WriteLine($"Car: {carCount}");
            Console.WriteLine();

            // smarta sättet
            // Involverar Linq metoden GroupBy
            var test = garage.GroupBy(v => v.GetType()).ToList();
            
        }
    }
}
