namespace DevNotes.OOP.Business
{
    public class InspectionBike : Bike
    {
        public DateTime Expiration { get; set; }

        public InspectionBike(string name, double price, double engine, double horsePower, DateTime expiration) : base(name, price, engine, horsePower)
        {
            this.Expiration = expiration;
        }

        public override string GetInfo()
        {
            return $"Modelo usado: {base.Name}, Cilindrada: {base.Engine}, Precio{base.Price}, Fecha revision: {this.Expiration}";
        }

    }
}
