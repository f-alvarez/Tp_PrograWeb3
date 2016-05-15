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

        public void add(Usuario usuario)
        {
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
    }
}
