using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentas.BL
{
    public class ProductosBL
    {
        public List<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "iPhone X";

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Samsung Galaxy S11";

            ListadeProductos = new List<Producto>();

            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
        }
    }
}
