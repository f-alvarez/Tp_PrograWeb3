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

        public List<Eventos> getAllOrFirtsSixEventosFiltrados()
        {
            var query = (from e in contexto.Eventos where e.Comentarios.Count > 0 where e.Estado == 3 select e);
            List<Eventos> lista = query.ToList();
            if (lista.Count > 6)
            {
                return query.Take(6).ToList();
            }
            else {
                return lista;
            }
        }

        public List<Eventos> getEventosByEstado(byte estado)
        {
            return (from e in contexto.Eventos where e.Estado == estado select e).ToList();
        }

        public List<Eventos> getEventosByEstadoYDisponibilidad(byte estado)
        {
            List<Eventos> listaRetornada = new List<Eventos>();
            List<Eventos> listaEventos = (from e in contexto.Eventos where e.Estado == estado select e).ToList();

            foreach (var evento in listaEventos)
            {
                List<Reservas> listaReservas = (from r in contexto.Reservas where r.IdEvento == evento.IdEvento select r).ToList();
                if (listaReservas.Count > 0)
                {
                    foreach (var reserva in listaReservas)
                    {
                        if (reserva.Cantidad < evento.CantidadComensales)
                        {
                            listaRetornada.Add(evento);
                        }
                    }
                }
                else {
                    listaRetornada.Add(evento);
                }
                
            }

            return listaRetornada;
        }

        public Eventos GetEventoById(int id) 
        {
            return (from e in contexto.Eventos where e.IdEvento == id select e).First();
        }

        public void CancelEvent(int id)
        {
            Eventos evento = GetEventoById(id);

            if (Convert.ToDateTime(evento.Fecha) > DateTime.Today && evento.Estado.Equals(1))
            {
                evento.Estado = 2;
            }

            contexto.SaveChanges();
        }

    }
}
