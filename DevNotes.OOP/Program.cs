using DevNotes.OOP.Business;

Bike hornet = new Bike("Hornet", 15000, 600, 96.5);
Console.WriteLine(hornet.GetInfo());

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
    hornet,
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

var elements = new Collection<int>(3);
elements.Add(10);
elements.Add(20);
elements.Add(309);
elements.Add(400);
foreach (int i in elements.Get())
{
    Console.WriteLine(i);
}

var names = new Collection<string>(2);
names.Add("John");
names.Add("Carlos");
foreach (string name in names.Get())
{
    Console.WriteLine(name);
}

var bikes = new Collection<Bike>(2);
bikes.Add(cbr6);
bikes.Add(hornet);
foreach (Bike bike in bikes.Get())
{
    Console.WriteLine(bike.Name);
}

