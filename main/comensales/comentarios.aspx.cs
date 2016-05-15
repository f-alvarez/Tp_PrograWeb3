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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listPuntu.Items.Add("1");
                listPuntu.Items.Add("2");
                listPuntu.Items.Add("3");
                listPuntu.Items.Add("4");
                listPuntu.Items.Add("5");

            }
        }
    }
}