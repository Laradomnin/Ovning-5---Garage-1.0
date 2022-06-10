using Ovning_5___Garage_1._0;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
int input;
bool done = false;
var garageHandler = new GarageHandler(6);
garageHandler.SeedData();
do
{
    Console.WriteLine(" Ange följande siffror:" +
            "\n 1 - för att skriva ut alla fordon i garaget " +
            "\n 2 - parkera fordon" +
            "\n 3 - Hämta fordon" +
            "\n 4 - Söka efter fordon utifrån färg " +
            "\n 5 - Statistik" +
            "\n 0 - för att avsluta ");


    if (!int.TryParse(Console.ReadLine(), out input) || input < 0 || input > 6)
    {
        Console.WriteLine("Ange rätt siffra. ");
    }
    else
    {
        switch (input)
        {
            case 1:
                garageHandler.PrintAllVehicles();
                break;
            case 2:
                CaseTwo.Help(garageHandler); 
                break;
            case 3:
                var userInputU = UI.AskForString("registreringsnummer för fordonet ni vill hämta");
                garageHandler.Unpark(userInputU);
                break;
            case 4:           
                var userInput = UI.AskForString();
                garageHandler.SearchByColorAndPrint(userInput);
                break;
            case 5:
                garageHandler.CountTypes();
                break;

            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Ange rätt ciffra,tack (0, 1, 2, 3, 4, 5 )");
                break;
                ;
        } 
        //var garage = new Garage<Vehicle>(3);

        //var airplane1 = new Airplane("AIR111", "Boeing", "787", "White", 40);
        //var airplane2 = new Airplane("AIR222", "Concord", "787", "Red", 40);
        //var airplane3 = new Airplane("AIR333", "SAAB", "B30", "White", 40);
        //var bus1 = new Bus("ABC142", "Scania", "Skolbuss", "Röd", 20);
        //var boat1 = new Boat("BBB45", "Sandström", "Cabinbåt", "Blå", 6);

        //garage.Park(airplane1);
        //garage.Park(airplane2);
        //garage.Park(airplane3);
        //garage.Park(bus1);
        //garage.Park(boat1);
        //garage.Unpark("AIR111");
        //foreach (var vehicle in garage)
        //{
        //    Console.WriteLine(vehicle.ToString());
        //}

        //var garageHandler = new GarageHandler(6);
        //garageHandler.SeedData();
        //garageHandler.Unpark("AIR222");
        //garageHandler.Park(new Boat("BBB45", "Sandström", "Cabinbåt", "Blå", 6));
        //garageHandler.SearchByColorAndPrint("White");
    }
}while (!done);
