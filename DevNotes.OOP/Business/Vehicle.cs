namespace DevNotes.OOP.Business
{
    public abstract class Vehicle
    {
        public double HorsePower { get; set; }

        public Vehicle(double horsePower)
        {
            this.HorsePower = horsePower;
        }

        public string GetHP()
        {
            return $"{HorsePower.ToString()} HP";
        }

        public abstract string GetCategory();
    }
}
