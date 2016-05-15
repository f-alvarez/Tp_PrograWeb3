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
        public static List<Evento> Eventos = new List<Evento>();

        public void add(Evento evento)
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
    }
}
