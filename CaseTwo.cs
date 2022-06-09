using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    public class CaseTwo
    {
        
        
        public static bool Help(GarageHandler garageHandler)
            {
      string userInputType;
      bool done = false;

            userInputType = UI.AskForString("fordonstyp (Bus, Boat, Airplane eller Car)");

            if ((!userInputType.ToLower().Equals("bus")
            || !userInputType.ToLower().Equals("boat")
            || !userInputType.ToLower().Equals("car")
            || !userInputType.ToLower().Equals("airplane")))
            

            { Console.WriteLine("Ange rätt parrameter"); }
              
           
                var regnr = UI.AskForString("registreringsnummer");
                var brand = UI.AskForString("märke");
                var name = UI.AskForString("namn");
                var color = UI.AskForString("färg");
           

            switch (userInputType.ToLower())
            {
                case "boat":
                    var length = Convert.ToDouble(UI.AskForString("längd"));
                    garageHandler.Park(new Boat(regnr, brand, name, color, length));
                    break;
                case "bus":
                    var nrOfSeats = Convert.ToUInt32(UI.AskForString("antal sittplatser"));

                    garageHandler.Park(new Bus(regnr, brand, name, color, nrOfSeats));
                    break;
            }
            
            return false;
        }
    }

       
}
