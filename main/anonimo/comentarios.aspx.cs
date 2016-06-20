using AccesoADatos;
using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main.anonimo
{
    public partial class comentarios : System.Web.UI.Page
    {

        static PW3_TP_20161CEntities contexto = new PW3_TP_20161CEntities();
        ComentariosRepository comentariosRepo = new ComentariosRepository(contexto);
        private int evento;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                evento = Convert.ToInt32(Request.QueryString["eventoId"]);
                cargarComentarios();
            }

           
        }

        private void cargarComentarios()
        {
            var comments = comentariosRepo.GetAllByEventId(evento);
            comentariosRepeater.DataSource = comments;
            comentariosRepeater.DataBind();
        }
    }
}