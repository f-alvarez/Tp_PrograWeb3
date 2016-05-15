﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using Entidades;

namespace Tp__PrograWeb3.main.cocineros
{
    public partial class eventos : System.Web.UI.Page
    {
        EventosRepository eventoRepositorio = EventosRepository.getInstance;
        UsuariosRepository UsuariosRepo = new UsuariosRepository();
        RecetasRepository RecetasRepo = new RecetasRepository();
        string filename = "";
        int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                this.userId = Int32.Parse(Session["userId"].ToString());
                CargarRecetas();
            }
        }

        private void CargarRecetas() {
            recetasListId.DataSource = RecetasRepo.GetAllByUserId(this.userId);
            recetasListId.DataTextField = "nombre";
            recetasListId.DataValueField = "recetaId";
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
                    var evento = new Evento();
                    evento.userId = this.userId;
                    evento.nombre = NombreId.Value;
                    evento.fecha = calendarId.ToString();
                    evento.descripcion = descripcionId.Value;
                    evento.cantidadComensales = Int32.Parse(comensalesId.Value);
                    evento.ubicacion = ubicacionId.Value;
                    evento.foto = this.filename;
                    evento.precio = Double.Parse(precioId.Value);
                    evento.estado = "PENDIENTE";
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
                    fotoId.SaveAs(Server.MapPath("~/fotos/") + this.filename);
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: Error al subir la imagen: " + ex.Message;
                }
            }
        }
    }
}