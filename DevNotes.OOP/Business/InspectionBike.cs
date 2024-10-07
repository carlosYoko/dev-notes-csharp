namespace DevNotes.OOP.Business
{
    public class InspectionBike : Bike
    {
        public DateTime Expiration { get; set; }

        public InspectionBike(string name, double price, decimal engine, DateTime expiration) : base(name, price, engine)
        {
            this.Expiration = expiration;
        }

        public override string GetInfo()
        {
            return $"Modelo usado: {base.Name},Cilindrada: {base.Engine}, Precio{base.Price}, Fecha revision: {this.Expiration}";
        }

    }
}
