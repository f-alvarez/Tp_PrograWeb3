using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp__PrograWeb3.main.comensales
{
    public partial class reservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Eventos> ListEven = new List<Eventos>();

            Eventos evento = new Eventos();
            evento.nombre = "Festival Raíz";
            evento.fecha = "25/5/2016";
            evento.descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            evento.estado = "Pendiente";

            Eventos evento1 = new Eventos();
            evento.nombre = "Sabores Etnicos";
            evento.fecha = "3/4/2016";
            evento.descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            evento.estado = "Realizado";

            Eventos evento2 = new Eventos();
            evento.nombre = "Food Markt";
            evento.fecha = "7/6/2016";
            evento.descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            evento.estado = "Cancelado";

            ListEven.Add(evento);
            ListEven.Add(evento1);
            ListEven.Add(evento2);




            gvListaEventos.DataSource = ListEven;
            gvListaEventos.DataBind();

        }
    }
}