using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class UsuariosRepository
    {
        PW3_TP_20161CEntities contexto;

        public UsuariosRepository(PW3_TP_20161CEntities context)
        {
            contexto = context;
        }

        public void add(Usuarios usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public Usuarios getById(int id)
        {
            /*int index = Usuarios.FindIndex(usuario => usuario.IdUsuario == id);
            if (index < 0)
            {
                return null;
            }
            else
            {
                return Usuarios.ElementAt(index);             
            }   */
            return new Usuarios();
        }

        public Usuarios getByMail(string mail)
        {
            var empleado = (from e in contexto.Usuarios where e.Email == mail select e).FirstOrDefault();
            return empleado;
        }

        public Usuarios getByMailAndPass(string mail, string pass)
        {

            /*int index = Usuarios.FindIndex(usuario => (usuario.Email == mail && usuario.Password == pass));
            if (index < 0)
            {
                return null;
            }
            else
            {
                return Usuarios.ElementAt(index);
            }*/

            return new Usuarios();
        }
    }
}
