using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Reserva
    {
        public int id {get; set;}
        public int userId {get; set;}
        public int eventoId {get; set;}
        public int recetaId { get; set; }
        public int cantidadComensales { get; set; }
    }
}
