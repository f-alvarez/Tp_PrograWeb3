using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoADatos;

namespace Tp__PrograWeb3.main.comensales
{
    public partial class reservar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvListaEventosAReservar.DataSource = new EventosRepository(new PW3_TP_20161CEntities()).getEventosByEstadoYDisponibilidad(1);
            gvListaEventosAReservar.DataBind();     
        }
    }
}