namespace DevNotes.FunctionalProgramming
{
    public class PureFunction
    {
        // No pure functions
        DateTime Tomorrow()
        {
            return DateTime.Now.AddDays(1);
        }

        Client ToUpperName(Client client)
        {
            client.Name = client.Name.ToUpper();
            return client;
        }

        // Pure functions
        DateTime TomorrowPure(DateTime date)
        {
            return date.AddDays(1);
        }

        Client ToUpperNamePure(Client client)
        {
            var toUpperClientName = new Client()
            {
                Name = client.Name.ToUpper()
            };

            return toUpperClientName;
        }
    }

    public class Client
    {
        public string Name { get; set; }
    }

}
