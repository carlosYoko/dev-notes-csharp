namespace DevNotes.AbstractClass
{
    public abstract class Vehicle
    {
        public int Engine { get; set; }
        protected Vehicle(int engine)
        {
            this.Engine = engine;
        }

        public string GetEngine()
        {
            return Engine + " cc";
        }

        public abstract string GetCategory();
    }
}
