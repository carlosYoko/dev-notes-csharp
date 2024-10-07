using DevNotes.OOP.Business;

Bike hornetBike = new Bike("Hornet", 15000, 600);

var cbr6 = new InspectionBike("CBR rr", 20000, 600, new DateTime(2027, 10, 08));

Console.WriteLine(hornetBike.GetInfo());
Console.WriteLine(cbr6.GetInfo());
Console.WriteLine(cbr6.GetInfo($"Moto con revision: "));