using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Repositorios
{
    public class UsuariosRepository
    {
        public static List<Usuario> Usuarios = new List<Usuario>();

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

        public void add(Usuario usuario)
        {
            usuario.id = Usuarios.Count; //ESTO FUNCIONA SIEMPRE Y CUANDO NO SE ELIMINEN RECETAS

            Usuarios.Add(usuario);
        }

        public Usuario getById(int id)
        {
            int index = Usuarios.FindIndex(usuario => usuario.id == id);
            if (index < 0)
            {
                return null;
            }
            else
            {
                return Usuarios.ElementAt(index);             
            }   
        }

        public Usuario getByMail(string mail)
        {

            int index = Usuarios.FindIndex(usuario => usuario.mail == mail);
            if (index < 0)
            {
                return null;
            }
            else
            {
                return Usuarios.ElementAt(index);
            }
        }

        public Usuario getByMailAndPass(string mail, string pass) {
            
            int index = Usuarios.FindIndex(usuario => (usuario.mail == mail && usuario.pass == pass));
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
