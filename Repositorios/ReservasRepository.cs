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
        PW3_TP_20161CEntities contexto;

        public ReservasRepository(PW3_TP_20161CEntities context) {
            contexto = context;
        }

        public void add(Reservas reserva)
        {
            contexto.Reservas.Add(reserva);
            contexto.SaveChanges();
        }

        public List<Reservas> GetAllByUserId(int userId)
        {
            Usuarios usuario = (from e in contexto.Usuarios where e.IdUsuario == userId select e).FirstOrDefault();

            return usuario.Reservas.ToList();
            
        }

        public List<Reservas> getAllReservas()
        {
            return (from e in contexto.Reservas select e).ToList();
        }

        public List<Reservas> getReservasByUserId(int userId) {

            return GetAllByUserId(userId);
        }

        public Reservas GetReservaById(int id) 
        {
            return (from e in contexto.Reservas where e.IdReserva == id select e).First();

        }
    }
}
