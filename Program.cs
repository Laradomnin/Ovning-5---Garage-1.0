using Ovning_5___Garage_1._0;
int input;
bool done = false;
var garageHandler = new GarageHandler(6);
garageHandler.SeedData();

Console.WriteLine(" Ange följande cifror:" +
        "\n 1 - för att skriva ut alla fordon i garaget " +
        "\n 2 - parkera fordon" +
        "\n 3 - unparkera fordon" +
        "\n 4 - Söka efter fordon utifrån en egenslap, ex färg "
        );
 ;

while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 4)
{
Console.WriteLine("Ange rätt cifra. ");
}
{
    switch (input)
    {
        case 1:
            garageHandler.PrintAllVehicles();
            break;
        case 2:
            garageHandler.Park(new Boat("BBB45", "Sandström", "Cabinbåt", "Blå", 6));
            break;
        case 3:
            garageHandler.Unpark("AIR222");
            break;
        case 4:
            garageHandler.SearchByColorAndPrint("White");
            break;
            default: Console.WriteLine("skriv ngt. ");
            break;
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
    //garageHandler.PrintAllVehicles(); }


