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

            string nombre = "Festival Raíz";
            string fecha = "25/5/2016";
            string descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            string estado = "Pendiente";
            Eventos evento = new Eventos(nombre,fecha,descripcion,estado);
            ListEven.Add(evento);

            nombre = "Sabores Etnicos";
            fecha = "3/4/2016";
            descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            estado = "Realizado";
            Eventos evento1 = new Eventos(nombre, fecha, descripcion, estado);
            ListEven.Add(evento1);

            nombre = "Food Markt";
            fecha = "7/6/2016";
            descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            estado = "Cancelado";
            Eventos evento2 = new Eventos(nombre, fecha, descripcion, estado);
            ListEven.Add(evento2);
            
            gvListaEventos.DataSource = ListEven;
            gvListaEventos.DataBind();            
        }





    }
}