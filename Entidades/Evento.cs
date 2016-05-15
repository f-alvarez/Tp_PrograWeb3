using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace Entidades
{
    public class Evento
    {
        public List<Receta> recetas { get; set; }
        public int cantidadComensales { get; set; }
        public string ubicacion { get; set; }
        public string foto { get; set; }
        public double precio { get; set; }
        public string nombre { get; set; }
        public string fecha { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }

    }
}