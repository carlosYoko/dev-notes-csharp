namespace DevNotes.OOP.Business
{
    public class Car : Vehicle
    {
        private const string Category = "Coche";

        public Car(double horsePower) : base(horsePower)
        {
        }

        public override string GetCategory()
        {
            return Category;
        }
    }
}
