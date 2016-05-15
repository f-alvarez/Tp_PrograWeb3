using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public int tipo { get; set; } //1:comensal. 2:cocinero
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string pass {get; set; }
        public string fechaIngreso { get; set; }
        public string mail { get; set; }

    }
}
