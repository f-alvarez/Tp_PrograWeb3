using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using AccesoADatos;

namespace Tp__PrograWeb3.main.cocineros
{
    public partial class perfil : System.Web.UI.Page
    {
        EventosRepository EventosRepo = new EventosRepository(new PW3_TP_20161CEntities());
        UsuariosRepository UsuariosRepo = new UsuariosRepository(new PW3_TP_20161CEntities());
        RecetasRepository RecetasRepo = new RecetasRepository(new PW3_TP_20161CEntities());

        static int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                userId = Int32.Parse(Session["userId"].ToString());
                CargarPerfil();
            }
        }

        private void CargarPerfil()
        {

            Usuarios usuario = UsuariosRepo.getById(userId);
            nombreId.Text = usuario.Nombre;
            fechaIngresoId.Text = usuario.FechaRegistracion.ToString();
            mailId.Text = usuario.Email;
            
            CargarRecetas();
            CargarEventos();
        }


        private void CargarRecetas()
        {
            recetasId.DataSource = RecetasRepo.GetAllByUserId(userId);
            recetasId.DataBind();

            if (recetasId.Items.Count > 0)
            {
                labelRecetas.Visible = false;
                labelCantidadRecetas.Text = labelCantidadRecetas.Text + (recetasId.Items.Count).ToString();
            }
            else
            {
                labelRecetas.Visible = true;
            }
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

      
    }
}