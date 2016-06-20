﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using AccesoADatos;

namespace Tp__PrograWeb3.main.comensales
{
    public partial class reservas : System.Web.UI.Page
    {
        ReservasRepository reservasRepo = new ReservasRepository(new PW3_TP_20161CEntities());
        EventosRepository EventosRepo = new EventosRepository(new PW3_TP_20161CEntities());
        static int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                userId = Int32.Parse(Session["userId"].ToString());
                CargarReservas();
            }
                      
        }

        private void CargarReservas() {

            List<Reservas> reservas = reservasRepo.getReservasByUserId(userId);
            List<Eventos> eventosReservados = new List<Eventos>();

            foreach (Reservas reserva in reservas) {
                Eventos evento = EventosRepo.GetEventoById(reserva.IdEvento);
                eventosReservados.Add(evento);
            }
            
            eventosReservadosId.DataSource = eventosReservados;
            eventosReservadosId.DataBind();  
        }



    }
}