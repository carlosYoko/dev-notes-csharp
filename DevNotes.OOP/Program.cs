using DevNotes.OOP.Business;

Bike hornetBike = new Bike("Hornet", 15000, 600, 96.5);

var cbr6 = new InspectionBike("CBR rr", 20000, 600, 120, new DateTime(2027, 10, 08));

Vehicle bandit = new Bike("Bandit", 10000, 600, 90.5);
Show(bandit);

Vehicle vehicle = new Car(250);
Show(vehicle);

vehicle = new Bike("Lightning", 25000, 600, 110);
Show(vehicle);

void Show(Vehicle vehicle) => Console.WriteLine(vehicle.GetCategory());

Console.WriteLine(bandit.GetCategory());
Console.WriteLine(bandit.GetHP());
Console.WriteLine(hornetBike.GetInfo());
Console.WriteLine(cbr6.GetInfo());
Console.WriteLine(cbr6.GetInfo($"Moto con revision: "));