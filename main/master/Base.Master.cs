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
        UsuariosRepository UsuarioRepo = new UsuariosRepository(new PW3_TP_20161CEntities());
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

            Usuarios usuarioCocinero = new Usuarios();
            usuarioCocinero.Nombre = "pepe";
            usuarioCocinero.Password = "A123456789";
            usuarioCocinero.Email = "pepe@cocinero.com";
            usuarioCocinero.FechaRegistracion = DateTime.Now;
            usuarioCocinero.IdTipoUsuario = 2;
            UsuarioRepo.add(usuarioCocinero);

            Usuarios usuarioComensal = new Usuarios();
            usuarioComensal.Nombre = "pepe";
            usuarioComensal.Password = "A123456789";
            usuarioComensal.Email = "pepe@comensal.com";
            usuarioComensal.FechaRegistracion = DateTime.Now;
            usuarioComensal.IdTipoUsuario = 1;
            UsuarioRepo.add(usuarioComensal);

            Recetas receta = new Recetas
            {
                IdReceta = 33,
                IdUsuario = UsuarioRepo.getByMailAndPass(usuarioCocinero.Email, usuarioCocinero.Password).IdUsuario,
                Nombre = "Pizza",
                TiempoCoccion = 30,
                Descripcion = "Amasar, poner pure de tomate, poner queso, wala!",
                Ingredientes = "Pure de Tomate, " + "Harina, " + "Queso",
                Tipo = 1
            };
            Recetas receta2 = new Recetas
            {
                IdReceta = 44,
                IdUsuario = UsuarioRepo.getByMailAndPass(usuarioCocinero.Email, usuarioCocinero.Password).IdUsuario,
                Nombre = "Milanesa napolitana con papas",
                TiempoCoccion = 35,
                Descripcion = "Freir milanesa, ponerle salsa y queso. Fritas papas",
                Ingredientes = "Pure de Tomate, " + "Papas, " + "Queso, ",
                Tipo = 1
            };

            int cantidadComensales = 10;
            string ubicacion = "Lavalle 348";
            string foto = "~/resources/img/02.jpg";
            decimal precio = 120.50m;
            string nombre = "Festival Raíz";
            DateTime fecha = DateTime.Parse("25/05/2016");
            string descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            byte estado = 1;
            /*  public int IdEvento { get; set; }
                public int IdUsuario { get; set; }
                public string Nombre { get; set; }
                public System.DateTime Fecha { get; set; }
                public string Descripcion { get; set; }
                public int CantidadComensales { get; set; }
                public string Ubicacion { get; set; }
                public string NombreFoto { get; set; }
                public decimal Precio { get; set; }
                public byte Estado { get; set; }
    
                public virtual ICollection<Comentarios> Comentarios { get; set; }
                public virtual Usuarios Usuarios { get; set; }
                public virtual ICollection<Reservas> Reservas { get; set; }
                public virtual ICollection<Recetas> Recetas { get; set; }*/
            Eventos evento1 = new Eventos
            {
                IdUsuario = UsuarioRepo.getByMailAndPass(usuarioCocinero.Email, usuarioCocinero.Password).IdUsuario,
                Recetas = new List<Recetas> { receta, receta2 },
                IdEvento = 1,
                CantidadComensales = cantidadComensales,
                Ubicacion = ubicacion,
                NombreFoto = foto,
                Precio = precio,
                Nombre = nombre,
                Fecha = fecha,
                Descripcion = descripcion,
                Estado = estado
            };

            cantidadComensales = 3;
            ubicacion = "San Martin 347";
            foto = "~/resources/img/Evento1.jpeg";
            precio = 220.50m;
            nombre = "La Festichola";
            fecha = DateTime.Parse("15/12/2016");
            descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            estado = 1;
            Eventos evento2 = new Eventos
            {
                IdUsuario = UsuarioRepo.getByMailAndPass(usuarioCocinero.Email, usuarioCocinero.Password).IdUsuario,
                Recetas = new List<Recetas> { receta, receta2 },
                IdEvento = 2,
                CantidadComensales = cantidadComensales,
                Ubicacion = ubicacion,
                NombreFoto = foto,
                Precio = precio,
                Nombre = nombre,
                Fecha = fecha,
                Descripcion = descripcion,
                Estado = estado
            };

            cantidadComensales = 3;
            ubicacion = "Av.Corrientes 2348";
            foto = "~/resources/img/05.jpg";
            precio = 300m;
            nombre = "Sabores Etnicos";
            fecha = DateTime.Parse("24/05/2016");
            descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur efficitur nulla ac metus dictum, ac porta purus lacinia. In et erat urna.";
            estado = 3;
            Eventos evento3 = new Eventos
            {
                IdUsuario = UsuarioRepo.getByMailAndPass(usuarioCocinero.Email, usuarioCocinero.Password).IdUsuario,
                Recetas = new List<Recetas> { receta, receta2 },
                IdEvento = 3,
                CantidadComensales = cantidadComensales,
                Ubicacion = ubicacion,
                NombreFoto = foto,
                Precio = precio,
                Nombre = nombre,
                Fecha = fecha,
                Descripcion = descripcion,
                Estado = estado
            };

            eventoRepositorio.agregarEvento(evento1);
            eventoRepositorio.agregarEvento(evento2);
            eventoRepositorio.agregarEvento(evento3);


        }
    }
}