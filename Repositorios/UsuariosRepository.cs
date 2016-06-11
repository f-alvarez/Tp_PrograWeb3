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
        public static List<Usuarios> Usuarios = new List<Usuarios>();

        private static UsuariosRepository UsuariosRepo;

        private UsuariosRepository() { }

        public static UsuariosRepository getInstance
        {
            get 
            {
                if (UsuariosRepo == null)
                {
                    UsuariosRepo = new UsuariosRepository();
                }
                return UsuariosRepo;
            }
        }

        public void add(Usuarios usuario)
        {
            usuario.IdUsuario = Usuarios.Count; //ESTO FUNCIONA SIEMPRE Y CUANDO NO SE ELIMINEN RECETAS

            Usuarios.Add(usuario);
        }

        public Usuarios getById(int id)
        {
            int index = Usuarios.FindIndex(usuario => usuario.IdUsuario == id);
            if (index < 0)
            {
                return null;
            }
            else
            {
                return Usuarios.ElementAt(index);             
            }   
        }

        public Usuarios getByMail(string mail)
        {

            int index = Usuarios.FindIndex(usuario => usuario.Email == mail);
            if (index < 0)
            {
                return null;
            }
            else
            {
                return Usuarios.ElementAt(index);
            }
        }

        public Usuarios getByMailAndPass(string mail, string pass)
        {

            int index = Usuarios.FindIndex(usuario => (usuario.Email == mail && usuario.Password == pass));
            if (index < 0)
            {
                return null;
            }
            else
            {
                return Usuarios.ElementAt(index);
            }
        }
    }
}
