using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_DE_PRODUCTOS
{
    internal class Papeles : Producto
    {
        protected string Tipo { get; set; }
        protected string Color { get; set; }
        protected string Tamaño { get; set; }

        public new void AlmacenarDatos()
        {
            base.AlmacenarDatos();

            Console.Write("Ingrese el tipo de papel: ");
            Tipo = Console.ReadLine();

            Console.Write("Ingrese el color del papel: ");
            Color = Console.ReadLine();

            Console.Write("Ingrese el tamaño del papel: ");
            Tamaño = Console.ReadLine();
        }

        public new void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Tipo de papel: {Tipo}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamaño}");
        }
    }

}
