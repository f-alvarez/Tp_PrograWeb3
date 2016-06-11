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
        public List<Eventos> Eventos = new List<Eventos>();

        private static EventosRepository EventosRepo;

        private EventosRepository() { }

        public static EventosRepository getInstance
        {
            get 
            {
                if (EventosRepo == null)
                {
                    EventosRepo = new EventosRepository();
                }
                return EventosRepo;
            }
        }
        public void agregarEvento(Eventos evento)
        {
            evento.IdEvento = Eventos.Count;
            Eventos.Add(evento);
        }
       
        public void update(Eventos eventoUpdated)
        {
            foreach (Eventos evento in Eventos)
            {
                if (evento.IdEvento == eventoUpdated.IdEvento)
                {
                    evento.CantidadComensales = eventoUpdated.CantidadComensales;
                    evento.Recetas = eventoUpdated.Recetas;
                    evento.Reservas = eventoUpdated.Reservas;
                    evento.Ubicacion = eventoUpdated.Ubicacion;
                    evento.NombreFoto = eventoUpdated.NombreFoto;
                    evento.Nombre = eventoUpdated.Nombre;
                    evento.Fecha = eventoUpdated.Fecha;
                    evento.Descripcion = eventoUpdated.Descripcion;
                    evento.Estado = eventoUpdated.Estado;
                }
            }
        }

        public List<Eventos> GetAllByUserId(int userId)
        {
            List<Eventos> eventosByUser = new List<Eventos>();

            foreach (Eventos evento in Eventos)
            {
                if (evento.IdUsuario == userId)
                {
                    eventosByUser.Add(evento);
                }
            }
            return eventosByUser;
            
        }

        public List<Eventos> getAllEventos()
        {
            return Eventos;
        }

        public List<Eventos> getEventosByEstado(string estado)
        {
            List<Eventos> eventosFilter = new List<Eventos>();

            foreach (Eventos evento in Eventos)
            {
                if (evento.Estado.Equals(estado))
                {
                    eventosFilter.Add(evento);
                }
            }
            return eventosFilter;
        }

        public Eventos GetEventoById(int id) 
        {
            Eventos eventoById = new Eventos();

            foreach (Eventos evento in Eventos)
            {
                if (evento.IdEvento == id)
                {
                    eventoById = evento;
                }
            }
            return eventoById;
        }

        public void CancelEvent(int id)
        {
            Eventos evento = new Eventos();
            evento = GetEventoById(id);

            if (Convert.ToDateTime(evento.Fecha) > DateTime.Now && string.Equals(evento.Estado, 1))
            {
                evento.Estado = 2;
            }
        }

    }
}
