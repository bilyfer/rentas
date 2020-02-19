using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.BL
{
    public class ProductosBL
    {
        public List<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new List<Producto>();

            Producto producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "iPhone X";
            producto1.Precio = 20000;
            producto1.Existencia = 10;

            Producto producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Samsung galaxy";
            producto2.Precio = 15000;
            producto2.Existencia = 20;

            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
        }
    }
}
