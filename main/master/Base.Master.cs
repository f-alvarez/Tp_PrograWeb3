using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using AccesoADatos;

namespace Tp__PrograWeb3.main.master
{
    public partial class Base : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            ucMenuCocinero.Visible = false;
            ucMenuComensal.Visible = false;
            ucMenuAnonimo.Visible = false;

            if (Session["userTipo"] != null) {

                switch (Session["userTipo"].ToString())
                {
                    case "1":
                        ucMenuComensal.Visible = true;
                        break;
                    case "2":
                        ucMenuCocinero.Visible = true;
                        break;
                }

            }else{
                ucMenuAnonimo.Visible = true;
            }
            
        }
    }
}