using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tp__PrograWeb3
{
    public class Eventos
    {
        public string nombre { get; set; }
        public string fecha { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }

        public Eventos(string nombre,string fecha,string descripcion,string estado) {
            this.nombre = nombre;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.estado = estado;
        }

    }
}