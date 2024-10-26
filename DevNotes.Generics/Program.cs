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

Show<string>(bikeRepository);

void Show<T>(IRepository<T> repository)
{
    foreach (var bike in repository.GetAll())
    {
        Console.WriteLine(bike);
    }
}
