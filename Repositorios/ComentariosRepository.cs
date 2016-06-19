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

        public ICollection<Comentarios> GetAllByEventId(int eventId)
        {
            var evento = (from e in contexto.Eventos where e.IdEvento == eventId select e).FirstOrDefault();
            return evento.Comentarios.ToList();
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
