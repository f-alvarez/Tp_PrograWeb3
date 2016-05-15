using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace Tp__PrograWeb3.main.comensales
{
    public partial class reservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Evento> ListEven = new List<Evento>();

            string nombre = "Festival Raíz";
            string fecha = "25/5/2016";
            string descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            string estado = "Pendiente";
            Evento evento1 = new Evento
            {
                nombre = nombre,
                fecha = fecha,
                descripcion = descripcion,
                estado = estado
            };
            ListEven.Add(evento1);

            nombre = "Sabores Etnicos";
            fecha = "3/4/2016";
            descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            estado = "Realizado";
            Evento evento2 = new Evento
            {
                nombre = nombre,
                fecha = fecha,
                descripcion = descripcion,
                estado = estado
            };
            ListEven.Add(evento2);

            nombre = "Food Markt";
            fecha = "7/6/2016";
            descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            estado = "Cancelado";
            Evento evento3 = new Evento
            {
                nombre = nombre,
                fecha = fecha,
                descripcion = descripcion,
                estado = estado
            };
            ListEven.Add(evento3);
            
            gvListaEventos.DataSource = ListEven;
            gvListaEventos.DataBind();            
        }





    }
}