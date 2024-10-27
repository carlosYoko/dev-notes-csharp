// ##################
// # Pure functions #
// ##################

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

public class Client
{
    public string Name { get; set; }
}


// ###############
// # Action Type #
// ###############
public class ActionType
{
    Action<string> show = Console.WriteLine;
    Action<int, int> add = AddTwoNumbers;

    public static void AddTwoNumbers(int a, int b)
    {
        var result = a + b;
    }
}

// Para ejecutar:
// show("Hello World");
// add(2, 2)
