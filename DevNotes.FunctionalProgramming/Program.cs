// ###############
// # Action Type #
// ###############
Action<string> sayHello = Console.WriteLine;
Action<int, int> add = AddTwoNumbers;
static void AddTwoNumbers(int a, int b)
{
    var result = a + b;
}

sayHello("Hello World");
add(2, 2);

// #####################
// # Lambda expression #
// #####################
Action<string> hi = name => Console.WriteLine($"Hello {name}");
hi("Carlos");

Action<string> show = Console.WriteLine;

Action<int, int> addNumbers = (a, b) => show((a + b).ToString());
addNumbers(2, 2);


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