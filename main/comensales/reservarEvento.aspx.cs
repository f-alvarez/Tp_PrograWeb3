using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using Entidades;

namespace Tp__PrograWeb3.main.comensales
{
    public partial class reservarEvento : System.Web.UI.Page
    {
        ReservasRepository reservasRepo = ReservasRepository.getInstance;
        EventosRepository eventosRepo = EventosRepository.getInstance;
        static int userId;
        static int cantidadReservas;
        static int eventoId;
        static int cantidadMaximaReservas;
        static Evento evento;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                userId = Int32.Parse(Session["userId"].ToString());
                CargarEvento();
            }
            
        }

        private void CargarEvento() {
            string Id = Request.QueryString["idEvento"];
            evento = eventosRepo.GetEventoById(Id);

            eventoNombreLabel.Text = evento.nombre;
            cantidadReservas = evento.reservas;
            cantidadMaximaReservas = evento.cantidadComensales;
            eventoId = Int32.Parse(evento.eventoId);

            recetasRadioListId.DataSource = evento.recetas;
            recetasRadioListId.DataTextField = "nombre";
            recetasRadioListId.DataValueField = "recetaId";
            recetasRadioListId.DataBind();
        }

        protected void ValidateComensales(object sender, ServerValidateEventArgs args)
        {
            if ((Int64.Parse(comensalesId.Value) + cantidadReservas) > cantidadMaximaReservas)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void Reservar(object sender, EventArgs e)
        {
            if (Page.IsValid) {
                Reserva reserva = new Reserva();
                reserva.userId = userId;
                reserva.eventoId = eventoId;
                reserva.recetaId = Int32.Parse(recetasRadioListId.SelectedValue);
                reserva.cantidadComensales = Int32.Parse(comensalesId.Value);
                reservasRepo.add(reserva);

                evento.reservas = evento.reservas + reserva.cantidadComensales;
                eventosRepo.update(evento);

                Response.Redirect( ResolveUrl("~/main/comensales/reservas.aspx"));
            }

        }
    }
}