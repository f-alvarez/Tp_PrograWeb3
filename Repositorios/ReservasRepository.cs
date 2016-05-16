using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Repositorios
{
    public class ReservasRepository
    {
        public List<Reserva> Reservas = new List<Reserva>();

        private static ReservasRepository ReservasRepo;

        private ReservasRepository() { }

        public static ReservasRepository getInstance
        {
            get 
            {
                if (ReservasRepo == null)
                {
                    ReservasRepo = new ReservasRepository();
                }
                return ReservasRepo;
            }
        }

        public void add(Reserva reserva)
        {
            reserva.id = Reservas.Count;
            Reservas.Add(reserva);
        }

        public List<Reserva> GetAllByUserId(int userId)
        {
            List<Reserva> reservasByUser = new List<Reserva>();

            foreach(Reserva reserva in Reservas){
                if (reserva.userId == userId)
                {
                    reservasByUser.Add(reserva);
                }
            }
            return reservasByUser;
            
        }

        public List<Reserva> getAllReservas()
        {
            return Reservas;
        }

        public List<Reserva> getReservasByUserId(int userId) {
            List<Reserva> reservasByUserId = new List<Reserva>();

            foreach (Reserva reserva in Reservas)
            {
                if (reserva.userId == userId) {
                    reservasByUserId.Add(reserva);
                }
            }

            return reservasByUserId;
        }

        public Reserva GetReservaById(int id) 
        {
            Reserva reservaById = new Reserva();

            foreach (Reserva reserva in Reservas)
            {
                if (reserva.id == id)
                {
                    reservaById = reserva;
                }
            }
            return reservaById;
        }
    }
}
