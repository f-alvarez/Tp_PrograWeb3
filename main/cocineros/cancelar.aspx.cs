using AccesoADatos;
using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main.cocineros
{
    public partial class cancelar : System.Web.UI.Page
    {
        EventosRepository EventosRepo = new EventosRepository(new PW3_TP_20161CEntities());

        static int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            userId = Int32.Parse(Session["userId"].ToString());
            CargarEventos();
        }

        private void CargarEventos()
        {
            List<Eventos> eventosFiltrados = EventosRepo.GetAllByUserId(userId).Where(x => x.Fecha > DateTime.Today && x.EstadoString.Equals("Pendiente")).ToList();
            eventosId.DataSource = eventosFiltrados;
            if (eventosFiltrados.Count != 0)
            {
                labelEventos.Visible = false;
            }
            else
            {
                labelEventos.Visible = true;
            }
            eventosId.DataBind();
        }

        protected void btnShowPopup_Click(object sender, EventArgs e)
        {
            int index;
            int.TryParse(((LinkButton)(sender)).CommandArgument.ToString(), out index);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + index + "');", true);
        }


    }
}