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
            this.Eventos.Add(evento);
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

        public Evento GetEventoById(int id) 
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
