using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorios;

namespace Tp__PrograWeb3.main.cocineros
{
    public partial class recetas : System.Web.UI.Page
    {
        RecetasRepository recetaRepositorio = new RecetasRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GuardarRecetaClick(object sender, EventArgs e)
        {
            try
            {
                var receta = new Receta();
                receta.nombre = nombreId.Value;
                receta.tiempoDeCoccion = Int32.Parse(tiempoId.Value);
                receta.descripcionYPasosDeRealizacion = descripcionId.Value;
                receta.tipo = tipoId.Text;
                receta.ingredientes = ingredientesId.Value;
                recetaRepositorio.add(receta);

                StatusLabel.Text = "Upload status: Guardado con éxito";
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Upload status: Error al guardar la receta: " + ex.Message;
                throw;
            }

        }
    }
}