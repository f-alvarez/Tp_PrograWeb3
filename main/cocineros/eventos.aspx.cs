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
        static PW3_TP_20161CEntities contexto = new PW3_TP_20161CEntities();
        EventosRepository eventoRepositorio = new EventosRepository(contexto);
        UsuariosRepository UsuariosRepo = new UsuariosRepository(contexto);
        RecetasRepository RecetasRepo = new RecetasRepository(contexto);
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
                    evento.NombreFoto = GuardarFoto();
                    evento.Precio = Decimal.Parse(precioId.Value);
                    evento.Estado = 1;

                    foreach (ListItem item in recetasListId.Items)
                    {
                        if (item.Selected)
                        {
                            evento.Recetas.Add(RecetasRepo.GetById(Int32.Parse(item.Value)));
                        }
                    }

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

        protected String GuardarFoto()
        {
            String filename = "";
            if (fotoId.HasFile)
            {
                try
                {
                    filename = "~/resources/img/" + fotoId.FileName;
                    fotoId.SaveAs(Server.MapPath("~/resources/img/") + fotoId.FileName);
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: Error al subir la imagen: " + ex.Message;
                }
            }
            return filename;
        }

    }
}