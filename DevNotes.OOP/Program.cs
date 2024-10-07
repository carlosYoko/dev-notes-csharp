using DevNotes.OOP.Business;

Bike hornetBike = new Bike("Hornet", 15000, 600, 96.5);

var cbr6 = new InspectionBike("CBR rr", 20000, 600, 120, new DateTime(2027, 10, 08));

Vehicle bandit = new Bike("Bandit", 10000, 600, 90.5);

Console.WriteLine(bandit.GetCategory());
Console.WriteLine(bandit.GetHP());
Console.WriteLine(hornetBike.GetInfo());
Console.WriteLine(cbr6.GetInfo());
Console.WriteLine(cbr6.GetInfo($"Moto con revision: "));