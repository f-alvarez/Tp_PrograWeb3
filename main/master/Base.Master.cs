using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using AccesoADatos;

namespace Tp__PrograWeb3.main.master
{
    public partial class Base : System.Web.UI.MasterPage
    {
        EventosRepository eventosRepo = new EventosRepository(new PW3_TP_20161CEntities());

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) {
                FinalizarEventosOutOfDate();
            }
            ucMenuCocinero.Visible = false;
            ucMenuComensal.Visible = false;
            ucMenuAnonimo.Visible = false;

            if (Session["userTipo"] != null) {

                switch (Session["userTipo"].ToString())
                {
                    case "1":
                        ucMenuComensal.Visible = true;
                        break;
                    case "2":
                        ucMenuCocinero.Visible = true;
                        break;
                }

            }else{
                ucMenuAnonimo.Visible = true;
            }
            
        }

        private void FinalizarEventosOutOfDate() {
            List<Eventos> eventosPendientes = eventosRepo.getEventosByEstado(1);

            foreach(Eventos evento in eventosPendientes){
                if (evento.Fecha < DateTime.Now) {
                    evento.Estado = 3;
                    eventosRepo.update(evento);
                }
            }
        }
    }

}