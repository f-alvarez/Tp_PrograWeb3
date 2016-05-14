using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            Redireccion(ucLabelTextoEmail.TextoTextBox);
        }

        private void Redireccion(string tipoUsuario)
        {
            string urlDestino = "login.aspx";
            switch (tipoUsuario)
            {
                case "Comensal@gmail.com":
                    urlDestino = String.Format("../comensales/reservas.aspx?tipoUsuario={0}", tipoUsuario);
                    break;
                case "Cocinero@gmail.com":
                    urlDestino = String.Format("../cocineros/perfil.aspx?tipoUsuario={0}", tipoUsuario);
                    break;
                default:
                break;
            }
            Response.Redirect(urlDestino);
        }
    }
}