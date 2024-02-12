// See https://aka.ms/new-console-template for more information
using GESTION_DE_PRODUCTOS;

Console.WriteLine("GESTION DE PRODUCTOS");
Console.WriteLine();

static void Main(string[] args )
{
    bool salir = false;

    do
    {
        MostrarMenu();
        char opcion = Console.ReadKey().KeyChar;

        switch (opcion)
        {
            case '1':
                GestionarProducto(new Papeles());
                break;

            case '2':
                GestionarProducto(new Utensilios());
                break;

            case '3':
                Console.WriteLine("\nSaliendo del programa.");
                salir = true;
                break;

            default:
                Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                break;
        }

        if (!salir)
        {
            Console.Write("\n¿Desea continuar? (s/n): ");
            char respuesta = Console.ReadKey().KeyChar;

            if (char.ToLower(respuesta) != 's')
            {
                salir = true;
            }
        }

    } while (!salir);
}

static void MostrarMenu()
{
    Console.WriteLine("\nMenú de opciones:");
    Console.WriteLine("1. Papeles");
    Console.WriteLine("2. Utensilios");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");
}

static void GestionarProducto(Producto producto)
{
    Console.WriteLine($"\nGestión de {producto.GetType().Name}:");

    producto.AlmacenarDatos();
    Console.WriteLine("\nDatos ingresados:");
    producto.MostrarDatos();
}

