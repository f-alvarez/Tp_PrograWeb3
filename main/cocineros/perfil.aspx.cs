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
        static PW3_TP_20161CEntities contexto;
        static EventosRepository EventosRepo;
        static UsuariosRepository UsuariosRepo;
        static RecetasRepository RecetasRepo;

        static int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                contexto = new PW3_TP_20161CEntities();
                EventosRepo = new EventosRepository(contexto);
                UsuariosRepo = new UsuariosRepository(contexto);
                RecetasRepo = new RecetasRepository(contexto);

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
                labelCantidadRecetas.Visible = true;
                labelCantidadRecetas.Text = labelCantidadRecetas.Text + (recetasId.Items.Count).ToString();
            }
            else
            {
                labelRecetas.Visible = true;
                labelCantidadRecetas.Visible = false;
            }
        }

        private void CargarEventos()
        {
            eventosId.DataSource = EventosRepo.GetAllByUserId(userId);
            eventosId.DataBind();

            if (eventosId.Items.Count == 0)
            {
                labelEventos.Visible = true;
            }
            else
            {
                labelEventos.Visible = false;
            }
        }

      
    }
}