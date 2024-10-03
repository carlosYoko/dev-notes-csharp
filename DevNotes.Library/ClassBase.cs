namespace DevNotes.Library
{
    public class Animal
    {
        public string Song { get; set; }
        public string Name { get; set; }

        public Animal(string name, string song)
        {
            Name = name;
            Song = song;
        }

        public void AnimalSays()
        {
            Console.WriteLine($"The animal says: {Song}");
        }

        public void ShowName()
        {
            Console.WriteLine($"The animal's name: {Name}");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, string song) : base(name, song)
        {
        }

        public void DogSays()
        {
            base.AnimalSays();
        }

        public void DogName()
        {
            Console.WriteLine(this.Name);
        }
    }

    public class Human : Animal
    {
        public Human(string name, string song) : base(name, song)
        {
        }

        public void HumanSays()
        {
            base.AnimalSays();
        }

        public void HumanName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
