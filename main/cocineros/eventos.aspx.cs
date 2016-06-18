using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using AccesoADatos;

namespace Tp__PrograWeb3.main.cocineros
{
    public partial class eventos : System.Web.UI.Page
    {
        EventosRepository eventoRepositorio = new EventosRepository(new PW3_TP_20161CEntities());
        UsuariosRepository UsuariosRepo = new UsuariosRepository(new PW3_TP_20161CEntities());
        RecetasRepository RecetasRepo = new RecetasRepository(new PW3_TP_20161CEntities());
        string filename = "";
        static int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                userId = Int32.Parse(Session["userId"].ToString());
                CargarRecetas();
            }
        }

        private void CargarRecetas() {
            recetasListId.DataSource = RecetasRepo.GetAllByUserId(userId);
            recetasListId.DataTextField = "Nombre";
            recetasListId.DataValueField = "IdReceta";
            recetasListId.DataBind();
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

            if (Page.IsValid)
            {
                try
                {
                    var evento = new Eventos();
                    evento.IdUsuario = userId;
                    evento.Nombre = NombreId.Value;
                    evento.Fecha = calendarId.SelectedDate;
                    evento.Descripcion = descripcionId.Value;
                    evento.CantidadComensales = Int32.Parse(comensalesId.Value);
                    evento.Ubicacion = ubicacionId.Value;
                    evento.NombreFoto = this.filename;
                    evento.Precio = Decimal.Parse(precioId.Value);
                    evento.Estado = 1;
                    eventoRepositorio.agregarEvento(evento);

                    StatusLabel.Text = "Upload status: Guardado con éxito";
                    Response.Redirect("perfil.aspx");
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: Error al guardar el evento: " + ex.Message;

                }
            };
            

        }

        protected void GuardarFoto()
        {
            if (fotoId.HasFile)
            {
                try
                {
                    this.filename = Guid.NewGuid().ToString() + Path.GetExtension(fotoId.FileName).ToString();
                    fotoId.SaveAs(Server.MapPath("~/resources/img/") + this.filename);
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: Error al subir la imagen: " + ex.Message;
                }
            }
        }
    }
}