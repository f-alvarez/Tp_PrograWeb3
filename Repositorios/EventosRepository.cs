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

        public List<Evento> GetAllByUserId(int UserId)
        {
            return null;
        }
    }
}
