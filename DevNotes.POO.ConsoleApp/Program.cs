Bike hornetBike = new Bike()
{
    Name = "Hornet",
    Price = 15000
};

var cbrBike = new Bike();
cbrBike.Name = "CBR RR";
cbrBike.Price = 20000;

Console.WriteLine(hornetBike.Name);
Console.WriteLine(cbrBike.Name + " " + cbrBike.Price);
Console.WriteLine(hornetBike.GetInfo());

public class Bike
{
    public string Name { get; set; }
    public double Price { get; set; }

    public string GetInfo()
    {
        return $"Modelo: {Name}, Precio: {Price}";
    }
}