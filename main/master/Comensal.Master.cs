using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main.master
{
    public partial class Comensal : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["userId"] != null)
            {

                if (!Session["userTipo"].ToString().Equals("1"))
                {
                    Response.Redirect(ResolveUrl("~/main/comensales/reservas.aspx"));
                };

            }
            else
            {
                Response.Redirect(ResolveUrl("~/main/anonimo/login.aspx"));
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}