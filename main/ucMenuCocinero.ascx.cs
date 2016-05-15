using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main
{
    public partial class ucMenuCocinero : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            if (Session["userId"] == null) {
                Response.Redirect(ResolveUrl("~/main/anonimo/login.aspx"));
            }
        }
    }
}