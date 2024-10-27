int limit = 10;
var bikes = new string[limit];
var index = 0;
int op = 0;

do
{
    Console.Clear();
    ShowMenu();
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            if (index < limit)
            {
                Console.Clear();
                Console.WriteLine("Escribe la marca de moto");
                var bike = Console.ReadLine();
                bikes[index++] = bike;
            }
            else
            {
                Console.WriteLine("No caben mas marcas");
            }
            break;

        case 2:
            ShowBikes(bikes, index);
            break;

        case 3:
            Console.WriteLine("Has salido de la aplicacion");
            break;

        default:
            Console.WriteLine("Opcion no valida");
            break;
    }

} while (op != 3);

void ShowMenu()
{
    Console.WriteLine("1. Agregar nombre");
    Console.WriteLine("2. Mostrar nombres");
    Console.WriteLine("3. Salir");
}

void ShowBikes(string[] bikes, int index)
{
    Console.Clear();
    Console.WriteLine("Marcas:");
    for (int i = 0; i <= index; i++)
    {
        Console.WriteLine(bikes[i]);

    }
    Console.WriteLine("Presiona cualquier tecla para continuar");
    Console.ReadLine();
}