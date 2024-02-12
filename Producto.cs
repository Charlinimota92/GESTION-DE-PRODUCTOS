using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_DE_PRODUCTOS
{
    internal class Producto
    {
        protected string Código { get; set; }
        protected string Nombre { get; set; }
        protected string Marca { get; set; }
        protected decimal Precio { get; set; }

        public void AlmacenarDatos()
        {
            Console.Write("Ingrese el código del producto: ");
            Código = Console.ReadLine();

            Console.Write("Ingrese el nombre del producto: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese la marca del producto: ");
            Marca = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
           Precio = Convert.ToDecimal(Console.ReadLine());
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Código: {Código}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Precio: {Precio}");
        }
    }

}

   