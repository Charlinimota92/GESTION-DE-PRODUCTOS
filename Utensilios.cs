using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_DE_PRODUCTOS
{
    internal class Utensilios : Producto
    {
        protected string Categoría { get; set; }
        protected double Peso { get; set; }

        public new void AlmacenarDatos()
        {
            base.AlmacenarDatos();

            Console.Write("Ingrese la categoría de utensilio: ");
            Categoría = Console.ReadLine();

            Console.Write("Ingrese el peso del utensilio: ");
            Peso = Convert.ToDouble(Console.ReadLine());
        }

        public new void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Categoría de utensilio: {Categoría}");
            Console.WriteLine($"Peso: {Peso} kg");
        }
    }

}
