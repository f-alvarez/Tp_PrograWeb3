using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using AccesoADatos;

namespace Tp__PrograWeb3.main.cocineros
{
    public partial class recetas : System.Web.UI.Page
    {
        RecetasRepository recetaRepositorio = new RecetasRepository(new PW3_TP_20161CEntities());
        static int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                userId = Int32.Parse(Session["userId"].ToString());
            }

        }

        protected void GuardarRecetaClick(object sender, EventArgs e)
        {
            try
            {
                Recetas receta = new Recetas();
                receta.IdUsuario = userId;
                receta.Nombre = nombreId.Value;
                receta.TiempoCoccion = Int32.Parse(tiempoId.Value);
                receta.Descripcion = descripcionId.Value;
                receta.Tipo = Byte.Parse(tipoId.Text);
                receta.Ingredientes = ingredientesId.Value;
                recetaRepositorio.add(receta);

                StatusLabel.Text = "Upload status: Guardado con éxito";
                Response.Redirect("perfil.aspx");

            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Upload status: Error al guardar la receta: " + ex.Message;
                throw;
            }

        }
    }
}