Bike hornetBike = new Bike("Hornet", 15000);

var cbrBike = new Bike("CBR RR", 20000);

Console.WriteLine(hornetBike.Name);
Console.WriteLine(cbrBike.Name + " " + cbrBike.Price);
Console.WriteLine(hornetBike.GetInfo());

public class Bike
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Bike(string name, double price)
    {
        this.Name = name;
        this.Price = price;
    }

    public string GetInfo()
    {
        return $"Modelo: {Name}, Precio: {Price}";
    }
}