using Entidades;
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
        EventosRepository EventosRepo = EventosRepository.getInstance;

        static int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            userId = Int32.Parse(Session["userId"].ToString());
            CargarEventos();
        }

        private void CargarEventos()
        {
            eventosId.DataSource = EventosRepo.GetAllByUserId(userId);
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

        protected void cancel_command(object sender, RepeaterCommandEventArgs e)
        {          
            EventosRepo.CancelEvent(e.CommandArgument.ToString());
            Response.Redirect("cancelar.aspx");
        }


    }
}