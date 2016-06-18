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
    public partial class reservarEvento : System.Web.UI.Page
    {
        ReservasRepository reservasRepo = ReservasRepository.getInstance;
        EventosRepository EventosRepo = new EventosRepository(new PW3_TP_20161CEntities());
        static int userId;
        static ICollection<Reservas> cantidadReservas;
        static int eventoId;
        static int cantidadMaximaReservas;
        static Eventos evento;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                userId = Int32.Parse(Session["userId"].ToString());
                CargarEvento();
            }
            
        }

        private void CargarEvento() {
            int Id = int.Parse(Request.QueryString["idEvento"]);
            evento = EventosRepo.GetEventoById(Id);

            eventoNombreLabel.Text = evento.Nombre;
            cantidadReservas = evento.Reservas;
            cantidadMaximaReservas = evento.CantidadComensales;
            eventoId = evento.IdEvento;

            recetasRadioListId.DataSource = evento.Recetas;
            recetasRadioListId.DataTextField = "nombre";
            recetasRadioListId.DataValueField = "recetaId";
            recetasRadioListId.DataBind();
        }

        protected void ValidateComensales(object sender, ServerValidateEventArgs args)
        {
            if ((Int64.Parse(comensalesId.Value) + cantidadReservas.Count) > cantidadMaximaReservas)
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
                Reservas reserva = new Reservas();
                reserva.IdUsuario = userId;
                reserva.IdEvento = eventoId;
                reserva.IdReceta = Int32.Parse(recetasRadioListId.SelectedValue);
                reserva.Cantidad = Int32.Parse(comensalesId.Value);
                reservasRepo.add(reserva);

                evento.Reservas.Add(reserva);
                EventosRepo.update(evento);

                Response.Redirect( ResolveUrl("~/main/comensales/reservas.aspx"));
            }
        }

    }
}