using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main.userControls
{
    public partial class ucLabelTexto : System.Web.UI.UserControl
    {

        public String TextoLabel
        {
            get { return lbl.Text; }
            set { lbl.Text = value; }
        }
        public String TextoTextBox
        {
            get { return txt.Text; }
            set { txt.Text = value; }
        }
        public TextBoxMode TxtType
        {
            get { return txt.TextMode; }
            set { txt.TextMode = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}