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
        EventosRepository eventosRepo = new EventosRepository(contexto);
        static int userId;
        static int evento;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                userId = Int32.Parse(Session["userId"].ToString());
                evento = Convert.ToInt32(Request.QueryString["eventoId"]);
                cargarListBoxPuntuacion();
                mostrarInfoEvento(evento);
            }
        }

        private void mostrarInfoEvento(int evento)
        {
            var eventoInfo = eventosRepo.GetEventoById(evento);
            lblEventoNombre.Text = eventoInfo.Nombre;
        }

        protected void btnSubmit_Click(object sender, EventArgs e) 
        {
            if (Page.IsValid)
            {
                int calificacion = Convert.ToInt32(listCalificacion.SelectedValue);
                string com = comentario.Value;

                if (!comentariosRepo.verificarComentarioExistente(userId, evento))
                {

                    comentariosRepo.SaveComent(calificacion, com, evento, userId);
                    Response.Redirect("reservas.aspx");

                }
                else
                {
                    Response.Redirect("comentarios.aspx");
                }

               
                
            }
        }

        private void cargarListBoxPuntuacion()
        {
            for (var i = 1; i <= 5; i++)
            {
                listCalificacion.Items.Add(i.ToString());
            }
       
        }
    }
}