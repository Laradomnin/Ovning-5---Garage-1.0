using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    public class CaseTwo
    {


        public static void Help(GarageHandler garageHandler)
        {
            string userInputType;
            while (true)

            {
                userInputType = UI.AskForString("fordonstyp (Bus, Boat, Airplane eller Car)");

                if ((!userInputType.ToLower().Equals("bus")
                || !userInputType.ToLower().Equals("boat")
                || !userInputType.ToLower().Equals("car")
                || !userInputType.ToLower().Equals("airplane")))


                 Console.WriteLine("Ange rätt parrameter"); 

                else
                Console.WriteLine("du parkerar  " + userInputType);

                //var regnr = UI.AskForString("registreringsnummer");
                //var brand = UI.AskForString("märke");
                //var name = UI.AskForString("namn");
                //var color = UI.AskForString("färg");


                switch (userInputType.ToLower())
                {
                    case "boat":
                        var regnr = UI.AskForString("registreringsnummer");
                        var brand = UI.AskForString("märke");
                        var name = UI.AskForString("namn");
                        var color = UI.AskForString("färg");
                        var length = Convert.ToDouble(UI.AskForString("längd"));
                        garageHandler.Park(new Boat(regnr, brand, name, color, length));
                        break;
                    case "bus":
                        var bbrand = UI.AskForString("märke");
                        var bname = UI.AskForString("namn");
                        var bcolor = UI.AskForString("färg");
                        var bregnr = UI.AskForString("registreringsnummer");                      
                        var nrOfSeats = Convert.ToUInt32(UI.AskForString("antal sittplatser"));        
                        garageHandler.Park(new Bus(bregnr, bbrand, bname, bcolor, nrOfSeats));
                        break;
                }

                
            }
        }


    }
}
