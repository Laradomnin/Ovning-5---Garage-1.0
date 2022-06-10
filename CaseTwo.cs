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
                        var nrOfSeats = Convert.ToUInt32(UI.AskForString1("antal sittplatser"));
                        if (nrOfSeats < 0)
                            throw new ArgumentException("fel");
                        else
                        garageHandler.Park(new Bus(bregnr, bbrand, bname, bcolor, nrOfSeats));
                        break;

                    case "car":
                        var regnrc = UI.AskForString("registreringsnummer");
                        var brandc = UI.AskForString("märke");
                        var namec = UI.AskForString("namn");
                        var colorc = UI.AskForString("färg");
                        var fuel = UI.AskForString("bränsle");
                        garageHandler.Park(new Car(regnrc, brandc, namec, colorc, fuel));
                        break;

                    case "airplane":
 
                        var regnra = UI.AskForString("registreringsnummer");
                        var branda = UI.AskForString("märke");
                        var namea = UI.AskForString("namn");
                        var colora = UI.AskForString("färg");
                        var wings = UI.AskForString1("wings");
                        garageHandler.Park(new Airplane(regnra, branda, namea, colora, Convert.ToUInt32(wings)));
                        break;
                  
                }

                
            }
        }


    }
}
