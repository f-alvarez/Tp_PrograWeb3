using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorios;

namespace Tp__PrograWeb3.main.master
{
    public partial class Base : System.Web.UI.MasterPage
    {
        UsuariosRepository UsuarioRepo = new UsuariosRepository();
        RecetasRepository recetaRepositorio = new RecetasRepository();
        EventosRepository eventoRepositorio = EventosRepository.getInstance;
        static bool mockDataLoaded = false;



        protected void Page_Init(object sender, EventArgs e) {

            //Para que ya existan datos en la aplicacion al iniciar
            if (!mockDataLoaded) {
                MockData();
                mockDataLoaded = true;            
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
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

        private void MockData() {

            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.id = 1;
            nuevoUsuario.nombre = "pepe";
            nuevoUsuario.pass = "A123456789";
            nuevoUsuario.mail = "pepe@cocinero.com";
            nuevoUsuario.fechaIngreso = DateTime.Now.ToString();
            nuevoUsuario.tipo = 2;
            UsuarioRepo.add(nuevoUsuario);

            Usuario nuevoUsuario2 = new Usuario();
            nuevoUsuario.id = 2;
            nuevoUsuario.nombre = "pepe";
            nuevoUsuario.pass = "A123456789";
            nuevoUsuario.mail = "pepe@comensal.com";
            nuevoUsuario.fechaIngreso = DateTime.Now.ToString();
            nuevoUsuario.tipo = 1;
            UsuarioRepo.add(nuevoUsuario2);

            Receta receta = new Receta
            {
                userId = UsuarioRepo.getByMailAndPass(nuevoUsuario.mail, nuevoUsuario.pass).id,
                nombre = "Pizza",
                tiempoDeCoccion = 30,
                descripcionYPasosDeRealizacion = "Amasar, poner pure de tomate, poner queso, wala!",
                ingredientes = "Pure de Tomate, " + "Harina, " + "Queso",
                tipo = "Casera"
            };
            Receta receta2 = new Receta
            {
                userId = UsuarioRepo.getByMailAndPass(nuevoUsuario.mail, nuevoUsuario.pass).id,
                nombre = "Milanesa napolitana con papas",
                tiempoDeCoccion = 35,
                descripcionYPasosDeRealizacion = "Freir milanesa, ponerle salsa y queso. Fritas papas",
                ingredientes = "Pure de Tomate, " + "Papas, " + "Queso, ",
                tipo = "Casera"
            };

            int cantidadComensales = 10;
            string ubicacion = "Lavalle 348";
            string foto = "~/resources/img/02.jpg";
            double precio = 120.50;
            string nombre = "Festival Raíz";
            string fecha = "25/5/2016";
            string descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            string estado = "Pendiente";
            Evento evento1 = new Evento
            {
                recetas = new List<Receta> { receta, receta2 },
                cantidadComensales = cantidadComensales,
                ubicacion = ubicacion,
                foto = foto,
                precio = precio,
                nombre = nombre,
                fecha = fecha,
                descripcion = descripcion,
                estado = estado
            };

            cantidadComensales = 3;
            ubicacion = "Lavalle 2348";
            foto = "~/resources/img/Evento1.jpeg";
            precio = 220.50;
            nombre = "La Festichola";
            fecha = "15/12/2016";
            descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            estado = "Pendiente";
            Evento evento2 = new Evento
            {
                recetas = new List<Receta> { receta, receta2 },
                cantidadComensales = cantidadComensales,
                ubicacion = ubicacion,
                foto = foto,
                precio = precio,
                nombre = nombre,
                fecha = fecha,
                descripcion = descripcion,
                estado = estado
            };

            eventoRepositorio.agregarEvento(evento1);
            eventoRepositorio.agregarEvento(evento2);
        
        
        }
    }
}