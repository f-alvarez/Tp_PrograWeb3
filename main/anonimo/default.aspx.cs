using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoADatos;
using Repositorios;

namespace Tp__PrograWeb3.main.anonimo
{
    public partial class _default : System.Web.UI.Page
    {
        EventosRepository EventosRepo = new EventosRepository(new PW3_TP_20161CEntities());

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEventos();
            }
        }

        private void CargarEventos() {
            eventosId.DataSource = EventosRepo.getAllEventos();
            if (eventosId.Items.Count == 0)
            {
                labelEventos.Visible = false;
            }
            else
            {
                labelEventos.Visible = true;
            }
            eventosId.DataBind();
        }
    }
}