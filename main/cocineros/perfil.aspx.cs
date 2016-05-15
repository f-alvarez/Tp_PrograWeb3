﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorios;

namespace Tp__PrograWeb3.main.cocineros
{
    public partial class perfil : System.Web.UI.Page
    {
        EventosRepository EventosRepo = EventosRepository.getInstance;
        UsuariosRepository UsuariosRepo = UsuariosRepository.getInstance;
        RecetasRepository RecetasRepo = RecetasRepository.getInstance;

        static int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                userId = Int32.Parse(Session["userId"].ToString());
                CargarPerfil();
            }
        }

        private void CargarPerfil()
        {

            Usuario usuario = UsuariosRepo.getById(userId);
            nombreId.Text = usuario.nombre;
            fechaIngresoId.Text = usuario.fechaIngreso;
            mailId.Text = usuario.mail;
            
            CargarRecetas();
            CargarEventos();
        }


        private void CargarRecetas()
        {
            recetasId.DataSource = RecetasRepo.GetAllByUserId(userId);
            if (recetasId.Items.Count == 0)
            {
                labelRecetas.Visible = false;
            }
            else
            {
                labelRecetas.Visible = true;
            }
            recetasId.DataBind();
        }

        private void CargarEventos()
        {
            eventosId.DataSource = EventosRepo.GetAllByUserId(userId);
            if (eventosId.Items.Count == 0)
            {
                labelEventos.Visible = false;
            }
            else
            {
                labelEventos.Visible = true;
            }
            eventosId.DataBind();
        }

      
    }
}