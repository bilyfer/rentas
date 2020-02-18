using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.BL;

namespace Ventas.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var productosBL = new ProductosBL();

            foreach (var producto in productosBL.ListadeProductos)
            {
                Console.WriteLine(producto.Descripcion);
            }

            Console.ReadLine();
        }
    }
}
