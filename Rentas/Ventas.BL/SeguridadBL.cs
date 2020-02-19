using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.BL
{
    public class SeguridadBL
    {
        List<Usuario> ListadeUsuarios;

        public SeguridadBL()
        {
            ListadeUsuarios = new List<Usuario>();

            var usuario1 = new Usuario();
            usuario1.Nombre = "admin";
            usuario1.Contrasena = "123";

            ListadeUsuarios.Add(usuario1);
        }

        public bool Autenticar(string usuario, string contrasena)
        {
            foreach (var u in ListadeUsuarios)
            {
                if (u.Nombre == usuario && u.Contrasena == contrasena)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
