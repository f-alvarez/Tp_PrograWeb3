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
            var usuario = (from e in contexto.Usuarios where e.IdUsuario == id select e).FirstOrDefault();
            return usuario;
        }

        public Usuarios getByMail(string mail)
        {
            var usuario = (from e in contexto.Usuarios where e.Email == mail select e).FirstOrDefault();
            return usuario;
        }

        public Usuarios getByMailAndPass(string mail, string pass)
        {
            var usuario = (from e in contexto.Usuarios where e.Email == mail where e.Password == pass select e).FirstOrDefault();
            return usuario;
        }
    }
}
