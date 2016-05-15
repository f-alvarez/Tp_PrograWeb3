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
        UsuariosRepository UsuariosRepo = new UsuariosRepository();
        RecetasRepository RecetasRepo = new RecetasRepository();

        int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.userId = 1; //obtener de la session o la url
                CargarPerfil();
            }
        }

        private void CargarPerfil()
        {
            //TODO:USAR ESTO UNA VEZ QUE SE GUARDE USUARIOS EN EL REPO DE USUARIOS
            ////Usuario usuario = UsuariosRepo.getById(this.userId);
            ////nombreId.Text = usuario.nombre + " " + usuario.apellido;
            ////fechaIngresoId.Text = usuario.fechaIngreso;
            ////mailId.Text = usuario.mail;

            Usuario usuario = UsuariosRepo.getById(this.userId);
            nombreId.Text = "pepe" + " " + "pepo";
            fechaIngresoId.Text = "12 de abril de 2012";
            mailId.Text = "pepe@gmail.com";
            
            CargarRecetas();
            CargarEventos();
        }


        private void CargarRecetas()
        {
            recetasId.DataSource = RecetasRepo.GetAllByUserId(this.userId);
            recetasId.DataBind();
        }

        private void CargarEventos()
        {
            eventosId.DataSource = EventosRepo.GetAllByUserId(this.userId);
            eventosId.DataBind();
        }
    }
}