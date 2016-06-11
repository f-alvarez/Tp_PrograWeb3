using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class ReservasRepository
    {
        public List<Reservas> Reservas = new List<Reservas>();

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

        public void add(Reservas reserva)
        {
            reserva.IdReserva = Reservas.Count;
            Reservas.Add(reserva);
        }

        public List<Reservas> GetAllByUserId(int userId)
        {
            List<Reservas> reservasByUser = new List<Reservas>();

            foreach(Reservas reserva in Reservas){
                if (reserva.IdUsuario == userId)
                {
                    reservasByUser.Add(reserva);
                }
            }
            return reservasByUser;
            
        }

        public List<Reservas> getAllReservas()
        {
            return Reservas;
        }

        public List<Reservas> getReservasByUserId(int userId) {
            List<Reservas> reservasByUserId = new List<Reservas>();

            foreach (Reservas reserva in Reservas)
            {
                if (reserva.IdUsuario == userId)
                {
                    reservasByUserId.Add(reserva);
                }
            }

            return reservasByUserId;
        }

        public Reservas GetReservaById(int id) 
        {
            Reservas reservaById = new Reservas();

            foreach (Reservas reserva in Reservas)
            {
                if (reserva.IdReserva == id)
                {
                    reservaById = reserva;
                }
            }
            return reservaById;
        }
    }
}
