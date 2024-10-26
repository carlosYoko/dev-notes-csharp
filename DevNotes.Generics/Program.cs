using DevNotes.Generics;

var box = new Box<int>(7);
Console.WriteLine(box.GetContent());
box.Set(12);
Console.WriteLine(box.GetContent());


var box2 = new Box<bool>(true);
Console.WriteLine(box2.GetContent());
box2.Set(false);
Console.WriteLine(box2.GetContent());

var bikeRepository = new BikeRepository();
bikeRepository.Add("Honda");
bikeRepository.Add("Yamaha");


// Funciones con generics

Show<string>(bikeRepository);

void Show<T>(IRepository<T> repository)
{
    foreach (var bike in repository.GetAll())
    {
        if (bike == null) continue;
        Console.WriteLine(bike);
    }
}


// Delegados con generics

Operation<int> add = (a, b) => a + b;
Operation<decimal> addDouble = (a, b) => a + b;
Operation<string> concatenate = (a, b) => $"{a} {b}";
Action<IRepository<string>> actionDelegate = Show;


Console.WriteLine(add(2, 5));
Console.WriteLine(addDouble(10.2m, 5.2m));
Console.WriteLine(concatenate("Hello", "World!"));
actionDelegate(bikeRepository);

delegate T Operation<T>(T el1, T el2);