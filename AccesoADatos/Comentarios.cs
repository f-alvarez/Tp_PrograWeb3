//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoADatos
{
    using System;
    using System.Collections.Generic;

    public partial class Comentarios
    {
        public int IdComentario { get; set; }
        public int IdEvento { get; set; }
        public int IdUsuario { get; set; }
        public byte Puntuacion { get; set; }
        public string Comentarios1 { get; set; }

        public virtual Eventos Eventos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual string nombreUsuario { get; set; }
    }

}