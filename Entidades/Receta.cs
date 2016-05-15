using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Receta
    {
        public int recetaId { get; set; }
        public string nombre { get; set; }
        public int userId { get; set; }
        public int tiempoDeCoccion { get; set; }
        public string descripcionYPasosDeRealizacion { get; set; }
        public string ingredientes { get; set; }
        public string tipo { get; set; }
    }
}
