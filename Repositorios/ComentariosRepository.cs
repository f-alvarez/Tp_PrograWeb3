using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class ComentariosRepository
    {
        PW3_TP_20161CEntities contexto;

        public ComentariosRepository(PW3_TP_20161CEntities context)
        {
            contexto = context;
        }

        public void add(Comentarios comentarios)
        {
            contexto.Comentarios.Add(comentarios);
            contexto.SaveChanges();
        }

     
        public List<Comentarios> GetAllByEventId(int eventId)
        {

            var cmt = (from c in contexto.Comentarios where c.IdEvento == eventId select c);

            foreach (var comment in cmt)
            {
                comment.nombreUsuario = (from u in contexto.Usuarios where u.IdUsuario == comment.IdUsuario select u.Nombre).FirstOrDefault();
            }

            return cmt.ToList();
           
        }

        public Comentarios GetById(int id)
        {
            return (from e in contexto.Comentarios where e.IdEvento == id select e).First();
        }

        public void SaveComent(int calificacion, string com, int evento, int user)
        {
            var comentario = new Comentarios();
            comentario.Comentarios1 = com;
            comentario.Puntuacion = (byte)calificacion;
            comentario.IdUsuario = user;
            comentario.IdEvento = evento;
            contexto.Comentarios.Add(comentario);
            contexto.SaveChanges();

        }
    }
}
