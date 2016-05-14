using Entidades;
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

            List<Evento> ListEven = new List<Evento>();
            Receta receta = new Receta{nombre = "Pizza", tiempoDeCoccion = 30, descripcionYPasosDeRealizacion = "Amasar, poner pure de tomate, poner queso, wala!",
            ingredientes = new List<string>(new string[] { "Pure de Tomate", "Harina", "Queso" }), tipo = "Casera"};

            int cantidadComensales = 3;
            string ubicacion = "Lavalle 348";
            string foto = "../resources/img/Evento1.jpeg";
            double precio = 120.50;
            string nombre = "Festival Raíz";
            string fecha = "25/5/2016";
            string descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            string estado = "Pendiente";
            Evento evento1 = new Evento
            {
                recetas = new List<Receta>{receta},
                cantidadComensales = cantidadComensales,
                ubicacion = ubicacion,
                foto = foto,
                precio = precio,
                nombre = nombre,
                fecha = fecha,
                descripcion = descripcion,
                estado = estado
            };
            ListEven.Add(evento1);


            gvListaEventosARecervar.DataSource = ListEven;
            gvListaEventosARecervar.DataBind();     
        }
    }
}