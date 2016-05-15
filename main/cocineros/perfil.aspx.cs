using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorios;

namespace Tp__PrograWeb3.main.cocineros
{
    public partial class perfil : System.Web.UI.Page
    {
        EventosRepository EventosRepo = new EventosRepository();
        UsuariosRepository UsuarioRepo = new UsuariosRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPerfil();
            }
        }

        private void CargarPerfil()
        {
            CargarEventos();
        }

        private void CargarEventos()
        {
            int UserId = 1;
            //gvEventos.DataSource = EventosRepo.GetAllByUserId(UserId);
            //gvEventos.DataBind();
        }
    }
}