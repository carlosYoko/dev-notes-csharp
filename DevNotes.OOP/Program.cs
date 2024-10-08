using DevNotes.OOP.Business;

Bike hornetBike = new Bike("Hornet", 15000, 600, 96.5);
Console.WriteLine(hornetBike.GetInfo());

var cbr6 = new InspectionBike("CBR rr", 20000, 600, 120, new DateTime(2027, 10, 08));
Console.WriteLine(cbr6.GetInfo());
Console.WriteLine(cbr6.GetInfo($"Moto con revision: "));

Vehicle bandit = new Bike("Bandit", 10000, 600, 90.5);
Console.WriteLine(bandit.GetCategory());
Console.WriteLine(bandit.GetHP());
Show(bandit);

Vehicle vehicle = new Car(250);
Show(vehicle);

vehicle = new Bike("Lightning", 25000, 600, 110);
Show(vehicle);

void Show(Vehicle vehicle) => Console.WriteLine(vehicle.GetCategory());

void SendSome(ISend some)
{
    some.Send();
}
SendSome(cbr6);

var service = new Service(100, 21);
Console.WriteLine(service.GetPrice());

ISalable[] concepts = [
    hornetBike,
    cbr6,
    service
    ];

double GetTotals(ISalable[] concepts)
{
    double total = 0;
    foreach (var concept in concepts)
    {
        total += concept.GetPrice();
    }

    return total;
}

Console.WriteLine(GetTotals(concepts));

Console.ReadKey();