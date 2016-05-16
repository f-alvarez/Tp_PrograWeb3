using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorios;

namespace Tp__PrograWeb3.main.comensales
{
    public partial class reservas : System.Web.UI.Page
    {
        ReservasRepository reservasRepo = ReservasRepository.getInstance;
        EventosRepository eventosRepo = EventosRepository.getInstance;
        static int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                userId = Int32.Parse(Session["userId"].ToString());
                CargarReservas();
            }
                      
        }

        private void CargarReservas() {

            List<Reserva> reservas = reservasRepo.getReservasByUserId(userId);
            List<Evento> eventosReservados = new List<Evento>();

            foreach (Reserva reserva in reservas) {
                Evento evento = eventosRepo.GetEventoById(reserva.eventoId.ToString());
                eventosReservados.Add(evento);
            }

            gvListaEventos.DataSource = eventosReservados;
            gvListaEventos.DataBind();  
        }





    }
}