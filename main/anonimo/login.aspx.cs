using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using Entidades;

namespace Tp__PrograWeb3.main
{
    public partial class login : System.Web.UI.Page
    {
        UsuariosRepository UsuarioRepo = UsuariosRepository.getInstance;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = UsuarioRepo.getByMailAndPass(ucLabelTextoEmail.TextoTextBox, ucLabelTextoPass.TextoTextBox);

            if (usuario != null)
            {
                Session["userNombre"] = usuario.nombre;
                Session["userId"] = usuario.id;
                Session["userTipo"] = usuario.tipo;

                Redireccion();
            }
            else {
                 //PADRE, DAME CODIGO
            }
            
        }

        private void Redireccion()
        {
            string urlDestino = "login.aspx";
            string tipoUsuario = Session["userTipo"].ToString();
            switch (tipoUsuario)
            {
                case "1":
                    urlDestino = String.Format("../comensales/reservas.aspx");
                    break;
                case "2":
                    urlDestino = String.Format("../cocineros/perfil.aspx");
                    break;
                default:
                break;
            }
            Response.Redirect(urlDestino);
        }
    }
}