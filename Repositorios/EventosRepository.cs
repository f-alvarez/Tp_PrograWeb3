using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class EventosRepository
    {
        PW3_TP_20161CEntities contexto;

        public EventosRepository(PW3_TP_20161CEntities context) {
            contexto = context;
        }

        public void agregarEvento(Eventos evento)
        {
            contexto.Eventos.Add(evento);
            contexto.SaveChanges();
        }
       
        public void update(Eventos eventoUpdated)
        {
            Eventos evento = (from e in contexto.Eventos where e.IdEvento == eventoUpdated.IdEvento select e).First();
            evento.CantidadComensales = eventoUpdated.CantidadComensales;
            evento.Recetas = eventoUpdated.Recetas;
            evento.Reservas = eventoUpdated.Reservas;
            evento.Ubicacion = eventoUpdated.Ubicacion;
            evento.NombreFoto = eventoUpdated.NombreFoto;
            evento.Nombre = eventoUpdated.Nombre;
            evento.Fecha = eventoUpdated.Fecha;
            evento.Descripcion = eventoUpdated.Descripcion;
            evento.Estado = eventoUpdated.Estado;
            evento.Precio = eventoUpdated.Precio;
            evento.Comentarios = eventoUpdated.Comentarios;
            evento.Usuarios = eventoUpdated.Usuarios;

            contexto.SaveChanges();
        }

        public List<Eventos> GetAllByUserId(int userId)
        {
            Usuarios usuario = (from e in contexto.Usuarios where e.IdUsuario == userId select e).FirstOrDefault();

            return usuario.Eventos.ToList();
            
        }

        public List<Eventos> getAllEventos()
        {
            return (from e in contexto.Eventos select e).ToList();
        }

        public List<Eventos> getEventosByEstado(byte estado)
        {
            return (from e in contexto.Eventos where e.Estado == estado select e).ToList();
        }

        public Eventos GetEventoById(int id) 
        {
            return (from e in contexto.Eventos where e.IdEvento == id select e).First();
        }

        public void CancelEvent(int id)
        {
            Eventos evento = GetEventoById(id);

            if (Convert.ToDateTime(evento.Fecha) > DateTime.Now && string.Equals(evento.Estado, 1))
            {
                evento.Estado = 2;
            }

            contexto.SaveChanges();
        }

    }
}
