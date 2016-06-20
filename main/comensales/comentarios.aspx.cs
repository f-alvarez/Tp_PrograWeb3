using AccesoADatos;
using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main.comensales
{
    public partial class comentarios : System.Web.UI.Page
    {
        static PW3_TP_20161CEntities contexto = new PW3_TP_20161CEntities();
        ComentariosRepository comentariosRepo = new ComentariosRepository(contexto);
        static int userId;
        static int evento;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                listCalificacion.Items.Add("1");
                listCalificacion.Items.Add("2");
                listCalificacion.Items.Add("3");
                listCalificacion.Items.Add("4");
                listCalificacion.Items.Add("5");
                userId = Int32.Parse(Session["userId"].ToString());
                evento = Convert.ToInt32(Request.QueryString["eventoId"]);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e) 
        {
            int calificacion = Convert.ToInt32(listCalificacion.SelectedValue);
            string com = comentario.Value;
            comentariosRepo.SaveComent(calificacion, com, evento, userId);
        }
    }
}