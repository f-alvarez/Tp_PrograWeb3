using AccesoADatos;
using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Tp__PrograWeb3.main.cocineros
{
    /// <summary>
    /// Descripción breve de eventos1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class eventos1 : System.Web.Services.WebService
    {
        EventosRepository EventosRepo = new EventosRepository(new PW3_TP_20161CEntities());
        [WebMethod(EnableSession = true)]
        public void Cancelar(int idEvento)
        {
            if (Session["userId"].ToString() != "" &&
            Session["userTipo"].ToString() == "2" &&
            EventosRepo.GetEventoById(idEvento) != null)
            {
                EventosRepo.CancelEvent(idEvento);
            }
            else {
                HttpContext context = HttpContext.Current;
                context.Response.StatusCode = 500;
            }
        }
    }
}
