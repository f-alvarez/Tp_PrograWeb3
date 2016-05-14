using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main.master
{
    public partial class Base : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string typeUser = Request.QueryString["tipoUsuario"];
            ucMenuCocinero.Visible = false;
            ucMenuComensal.Visible = false;
            ucMenuAnonimo.Visible = false;
            switch (typeUser)
            {
                case "Comensal":
                    ucMenuComensal.Visible = true;
                    break;
                case "Cocinero":
                    ucMenuCocinero.Visible = true;
                    break;
                default:
                    ucMenuAnonimo.Visible = true;
                break;
            }
        }
    }
}