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

            ListadeProductos.Add(producto1);
        }
    }
}
