using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Repositorios
{
    public class EventosRepository
    {
        public List<Evento> Eventos = new List<Evento>();

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
        public void agregarEvento(Evento evento)
        {
            Eventos.Add(evento);
        }

        public List<Evento> GetAllByUserId(int userId)
        {
            List<Evento> eventosByUser = new List<Evento>();

            foreach(Evento evento in Eventos){
                if (evento.userId == userId)
                {
                    eventosByUser.Add(evento);
                }
            }
            return eventosByUser;
            
        }

        public List<Evento> getAllEventos(){
            return Eventos;
        }

        public List<Evento> getEventosByEstado(string estado)
        {
            List<Evento> eventosFilter = new List<Evento>();

            foreach (Evento evento in Eventos)
            {
                if (evento.estado.Equals(estado))
                {
                    eventosFilter.Add(evento);
                }
            }
            return eventosFilter;
        }

        public Evento GetEventoById(string id) 
        { 
            Evento eventoById = new Evento();

             foreach(Evento evento in Eventos){
                if (evento.eventoId == id)
                {
                    eventoById = evento;
                }
            }
            return eventoById;
        }
    }
}
