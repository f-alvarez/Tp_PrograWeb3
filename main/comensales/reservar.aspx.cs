﻿using Entidades;
using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main.comensales
{
    public partial class reservar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EventosRepository eventoRepo = EventosRepository.getInstance;
            gvListaEventosAReservar.DataSource = eventoRepo.Eventos;
            gvListaEventosAReservar.DataBind();     
        }
    }
}