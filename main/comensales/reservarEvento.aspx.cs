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
        static PW3_TP_20161CEntities contexto = new PW3_TP_20161CEntities();
        ReservasRepository reservasRepo = new ReservasRepository(contexto);
        EventosRepository EventosRepo = new EventosRepository(contexto);
        static int userId;
        static int cantidadReservas;
        static int eventoId;
        static int cantidadMaximaReservas;
        static Eventos evento;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                userId = Int32.Parse(Session["userId"].ToString());
                cantidadReservas = 0;
                cantidadMaximaReservas = 0;
                CargarEvento();
            }
        }

        private void CargarEvento() {
            int Id = int.Parse(Request.QueryString["idEvento"]);
            evento = EventosRepo.GetEventoById(Id);
            eventoNombreLabel.Text = evento.Nombre;
            foreach (var item in evento.Reservas)
            {
                cantidadReservas += item.Cantidad;
            }
            cantidadMaximaReservas = evento.CantidadComensales;
            eventoId = evento.IdEvento;

            recetasRadioListId.DataSource = evento.Recetas;
            recetasRadioListId.DataTextField = "nombre";
            recetasRadioListId.DataValueField = "idReceta";
            recetasRadioListId.DataBind();
        }

        protected void ValidateComensales(object sender, ServerValidateEventArgs args)
        {
            if ((Int32.Parse(comensalesId.Value) + cantidadReservas) <= cantidadMaximaReservas)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
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