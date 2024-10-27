namespace DevNotes.AbstractClass
{
    internal class Bike : Vehicle
    {
        private const string Category = "Bike";
        public string Brand { get; set; }
        public int Power { get; set; }

        public Bike(string brand, int power, int engine) : base(engine)
        {
            Brand = brand;
            Power = power;
        }

        public override string GetCategory()
        {
            return Category;
        }
    }
}
