namespace DevNotes.OOP.Business
{
    public class Bike
    {
        private decimal _engine;
        public string Name { get; set; }
        protected double Price { get; set; }
        public decimal Engine
        {
            get { return _engine; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                _engine = value;
            }
        }
        public string SEngine
        {
            get { return "Cilindrada: " + _engine.ToString(); }
        }

        public Bike(string name, double price, decimal engine)
        {
            this.Name = name;
            this.Price = price;
            this.Engine = engine;
        }

        public string GetInfo()
        {
            return $"Modelo: {Name}, Precio: {Price}, Cilindrada: {Engine}";
        }
    }
}
