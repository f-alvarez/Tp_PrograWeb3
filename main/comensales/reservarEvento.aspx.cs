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
        protected void Page_Load(object sender, EventArgs e)
        {
            string Id = Request.QueryString["idEvento"];
            Evento evento = EventosRepository.getInstance.GetEventoById(Id);
            RecetasRepeater.DataSource = evento.recetas;
            RecetasRepeater.DataBind();
        }
    }
}