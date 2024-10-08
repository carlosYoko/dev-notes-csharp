namespace DevNotes.OOP.Business
{
    public class Service : ISalable
    {
        private double _amount;
        private double _tax;

        public Service(double amount, double tax)
        {
            this._amount = amount;
            this._tax = tax;
        }
        public double GetPrice()
        {
            return (_amount * (_tax / 100)) + _amount;
        }
    }
}
