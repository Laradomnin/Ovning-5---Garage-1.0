using Ovning_5___Garage_1._0;
//do
    Console.WriteLine("Ange 1 - för att ta ut fordon," +
        "\n 2- parkera fordon"+
        "\n 3- parkera fordon"+
        "\n 4- parkera fordon");
    //string? input = Console.ReadLine;
//while (true);

    {

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

var garageHandler = new GarageHandler(6);
garageHandler.SeedData();
garageHandler.Unpark("AIR222");

garageHandler.SearchByColorAndPrint("White");


