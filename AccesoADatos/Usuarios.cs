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
    
    public partial class Usuarios
    {
        public Usuarios()
        {
            this.Comentarios = new HashSet<Comentarios>();
            this.Eventos = new HashSet<Eventos>();
            this.Recetas = new HashSet<Recetas>();
            this.Reservas = new HashSet<Reservas>();
        }
    
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public System.DateTime FechaRegistracion { get; set; }
        public byte IdTipoUsuario { get; set; }
    
        public virtual ICollection<Comentarios> Comentarios { get; set; }
        public virtual ICollection<Eventos> Eventos { get; set; }
        public virtual ICollection<Recetas> Recetas { get; set; }
        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}
