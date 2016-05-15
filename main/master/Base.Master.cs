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
        EventosRepository eventoRepositorio = new EventosRepository();
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
            nuevoUsuario.nombre = "pepe";
            nuevoUsuario.pass = "A123456789";
            nuevoUsuario.mail = "pepe@cocinero.com";
            nuevoUsuario.fechaIngreso = DateTime.Now.ToString();
            nuevoUsuario.tipo = 2;
            UsuarioRepo.add(nuevoUsuario);

            Receta receta = new Receta();
            receta.userId = UsuarioRepo.getByMailAndPass(nuevoUsuario.mail, nuevoUsuario.pass).id;
            receta.nombre = "Pizza";
            receta.tiempoDeCoccion = 30;
            receta.descripcionYPasosDeRealizacion = "Hola soy una Pizza. Cociname.";
            receta.tipo = "CASERA";
            receta.ingredientes = "Harina, Tomate";
            recetaRepositorio.add(receta);

            var evento = new Evento();
            evento.userId = UsuarioRepo.getByMailAndPass(nuevoUsuario.mail, nuevoUsuario.pass).id;
            evento.nombre = "Pizzas al vapor";
            evento.fecha = DateTime.Now.ToString();
            evento.descripcion = "Hola soy un evento. Reservame.";
            evento.cantidadComensales = 30;
            evento.ubicacion = "GBA";
            evento.foto = "/fotos/pizza.jpg";
            evento.precio = Double.Parse("12.00");
            evento.estado = "PENDIENTE";
            eventoRepositorio.add(evento);
        
        
        }
    }
}