using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main.cocineros
{
    public partial class eventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ValidarRecetaSeleccionada(object source, ServerValidateEventArgs args)
        {
            args.IsValid = recetasListId.SelectedItem != null;
        }

        protected void DateCustVal_Validate(object source, ServerValidateEventArgs args)
        {
            if (calendarId.SelectedDate < DateTime.Now)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void GuardarEventoClick(object sender, EventArgs e)
        {
            try
            {
                GuardarFoto();
                StatusLabel.Text = "Upload status: File uploaded!";
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void GuardarFoto()
        {
            if (fotoId.HasFile)
            {
                try
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(fotoId.FileName).ToString();
                    fotoId.SaveAs(Server.MapPath("~/fotos/") + filename);
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: Error al subir la imagen: " + ex.Message;
                }
            }
        }
    }
}