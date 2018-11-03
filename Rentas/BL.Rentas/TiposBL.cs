using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class TiposBL
    {
        Contexto _contexto;

        public BindingList<Tipo> ListaTipos { get; set; }

        public TiposBL()
        {
            _contexto = new Contexto();
            ListaTipos = new BindingList<Tipo>();
        }

        public BindingList<Tipo> ObtenerTipos()
        {
            _contexto.Tipos.Load();
            ListaTipos = _contexto.Tipos.Local.ToBindingList();

            return ListaTipos;
        }
    }

    public class Tipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
