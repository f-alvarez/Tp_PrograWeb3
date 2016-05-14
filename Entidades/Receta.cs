using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Receta
    {
        public string nombre { get; set; }
        public int tiempoDeCoccion { get; set; }
        public string descripcionYPasosDeRealizacion { get; set; }
        public List<string> ingredientes { get; set; }
        public string tipo { get; set; }
    }
}
