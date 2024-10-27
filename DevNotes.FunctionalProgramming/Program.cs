// ###############
// # Action Type #
// ###############
Action<string> sayHello = Console.WriteLine;
static void AddTwoNumbers(int a, int b)
{
    var result = a + b;
}
sayHello("Hello World");

Action<int, int> add = AddTwoNumbers;
add(2, 2);


// #####################
// # Lambda expression #
// #####################
Action<string> hi = name => Console.WriteLine($"Hello {name}");
hi("Carlos");

Action<string> show = Console.WriteLine;
Action<int, int> addNumbers = (a, b) => show((a + b).ToString());
addNumbers(2, 2);


// #############
// # Func Type #
// #############
Func<int, int, int> mul = (a, b) => a * b;
show(mul(3, 4).ToString());

Func<int, int, string> mulString = (a, b) =>
 {
     var result = a * b;
     return result.ToString();
 };
show(mulString(4, 4));


// ##########################
// # Higher Order Functions #
// ##########################
List<int> list = [1, 2, 3, 4, 5, 6];
var listFiltered = Filter(list, n => n % 2 == 0);
var listFiltered2 = Filter(list, n => n > 3);

List<int> Filter(List<int> list, Func<int, bool> condition)
{
    var result = new List<int>();
    foreach (int i in list)
    {
        if (condition(i)) result.Add(i);
    }

    return result;
}


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