namespace DevNotes.OOP.Business
{
    public class InspectionBike : Bike
    {
        public DateTime Expiration { get; set; }

        public InspectionBike(string name, double price, decimal engine, DateTime expiration) : base(name, price, engine)
        {
            this.Expiration = expiration;
        }
    }
}
