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
        UsuariosRepository UsuarioRepo = UsuariosRepository.getInstance;
        RecetasRepository recetaRepositorio = RecetasRepository.getInstance;
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

            Usuario usuarioCocinero = new Usuario();
            usuarioCocinero.nombre = "pepe";
            usuarioCocinero.pass = "A123456789";
            usuarioCocinero.mail = "pepe@cocinero.com";
            usuarioCocinero.fechaIngreso = DateTime.Now.ToString();
            usuarioCocinero.tipo = 2;
            UsuarioRepo.add(usuarioCocinero);

            Usuario usuarioComensal = new Usuario();
            usuarioComensal.nombre = "pepe";
            usuarioComensal.pass = "A123456789";
            usuarioComensal.mail = "pepe@comensal.com";
            usuarioComensal.fechaIngreso = DateTime.Now.ToString();
            usuarioComensal.tipo = 1;
            UsuarioRepo.add(usuarioComensal);

            Receta receta = new Receta
            {
                recetaId = 33,
                userId = UsuarioRepo.getByMailAndPass(usuarioCocinero.mail, usuarioCocinero.pass).id,
                nombre = "Pizza",
                tiempoDeCoccion = 30,
                descripcionYPasosDeRealizacion = "Amasar, poner pure de tomate, poner queso, wala!",
                ingredientes = "Pure de Tomate, " + "Harina, " + "Queso",
                tipo = "Casera"
            };
            Receta receta2 = new Receta
            {
                recetaId = 44,
                userId = UsuarioRepo.getByMailAndPass(usuarioCocinero.mail, usuarioCocinero.pass).id,
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
                userId = UsuarioRepo.getByMailAndPass(usuarioCocinero.mail, usuarioCocinero.pass).id, 
                recetas = new List<Receta> { receta, receta2 },
                eventoId = "1",
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
            ubicacion = "San Martin 347";
            foto = "~/resources/img/Evento1.jpeg";
            precio = 220.50;
            nombre = "La Festichola";
            fecha = "15/12/2016";
            descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            estado = "Cancelado";
            Evento evento2 = new Evento
            {
                userId = UsuarioRepo.getByMailAndPass(usuarioCocinero.mail, usuarioCocinero.pass).id, 
                recetas = new List<Receta> { receta, receta2 },
                eventoId = "2",
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
            ubicacion = "Av.Corrientes 2348";
            foto = "~/main/fotos/05.jpg";
            precio = 300;
            nombre = "Sabores Etnicos";
            fecha = "24/05/2016";
            descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            estado = "Realizado";
            Evento evento3 = new Evento
            {
                userId = UsuarioRepo.getByMailAndPass(usuarioCocinero.mail, usuarioCocinero.pass).id, 
                recetas = new List<Receta> { receta, receta2 },
                eventoId = "3",
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
            eventoRepositorio.agregarEvento(evento3);


        }
    }
}