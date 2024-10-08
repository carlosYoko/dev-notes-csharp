﻿namespace DevNotes.OOP.Business
{
    public class Bike : Vehicle, ISalable, ISend
    {
        private const string Category = "Moto";
        private double _engine;
        public string Name { get; set; }
        protected double Price { get; set; }
        public static int QuantityObjects;
        public double Engine
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

        public Bike(string name, double price, double engine, double horsePower) : base(horsePower)
        {
            this.Name = name;
            this.Price = price;
            this.Engine = engine;
            QuantityObjects++;
        }

        public virtual string GetInfo()
        {
            return $"Modelo: {Name}, Precio: {Price}, Cilindrada: {Engine}";
        }

        public string GetInfo(string message)
        {
            return message + " " + this.GetInfo();
        }

        public override string GetCategory()
        {
            return Category;
        }

        public double GetPrice()
        {
            return Price;
        }

        public void Send()
        {
            Console.WriteLine($"Enviado: {this.GetInfo()}");
        }
    }
}
