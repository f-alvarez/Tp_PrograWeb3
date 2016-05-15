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
        protected void Page_Load(object sender, EventArgs e)
        {
            gvListaEventos.DataSource = EventosRepository.getInstance.getAllEventos();
            gvListaEventos.DataBind();            
        }





    }
}