using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main.userControls
{
    public partial class ucEventosInicio : System.Web.UI.UserControl
    {

        public String imgSrcUrl
        {
            get { return ImgEvento.ImageUrl; }
            set { ImgEvento.ImageUrl = value; }
        }
        public String imgLink
        {
            get { return linkImgEvento.NavigateUrl; }
            set { linkImgEvento.NavigateUrl = value; }
        }
        public String TextLink
        {
            get { return linkNombreEvento.Text; }
            set { linkNombreEvento.Text = value; }
        }
        public String urlLink
        {
            get { return linkNombreEvento.NavigateUrl; }
            set { linkNombreEvento.NavigateUrl = value; }
        }
        public String LabelPrecio
        {
            get { return lblPrecio.Text; }
            set { lblPrecio.Text = value; }
        }
        public String LabelPuntuacion
        {
            get { return lblPuntuacion.Text; }
            set { lblPuntuacion.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}