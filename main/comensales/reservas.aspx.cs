using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using AccesoADatos;

namespace Tp__PrograWeb3.main.comensales
{
    public partial class reservas : System.Web.UI.Page
    {
        static PW3_TP_20161CEntities contexto;
        static ReservasRepository reservasRepo;
        static EventosRepository EventosRepo;
        static ComentariosRepository comentariosRepo;
        static int userId;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                contexto = new PW3_TP_20161CEntities();
                reservasRepo = new ReservasRepository(new PW3_TP_20161CEntities());
                EventosRepo = new EventosRepository(new PW3_TP_20161CEntities());
                comentariosRepo = new ComentariosRepository(new PW3_TP_20161CEntities());

                userId = Int32.Parse(Session["userId"].ToString());
                CargarReservas();
            }
                      
        }

        private void CargarReservas() {

            List<Reservas> reservas = reservasRepo.getReservasByUserId(userId);
            List<Eventos> eventosReservados = new List<Eventos>();

            foreach (Reservas reserva in reservas) {
                Eventos evento = EventosRepo.GetEventoById(reserva.IdEvento);
                evento.eventoComentado = comentariosRepo.verificarComentarioExistente(userId, reserva.IdEvento);
                eventosReservados.Add(evento);

            }

            
            eventosReservadosId.DataSource = eventosReservados;
            eventosReservadosId.DataBind();  
        }



    }
}