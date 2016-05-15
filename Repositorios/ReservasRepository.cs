using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class ReservasRepository
    {
        //TODO todo... copiastear
        public static List<Reserva> reservas = new List<Reserva>();      //static una sola instancia de esto // como es estatico
        //   public Dictionary<int,Empleado> emp

        /* c
         {
             Items.Add(o);
         }

         public void Eliminar(Empleado o)            // buscar con constis
         {
             Items.Remove(o);
         }

         public void Modificar(Empleado o)            // buscar con constis
         {
             Empleado empViejo = Obtener(o.Legajo);
             if (empViejo != null)
             {
                 empViejo = o;
             }
         }

         public List<Empleado> ObtenerTodos()
         {
             return Items;           // puedo hacer publica la variable Items o crear este metodo
         }

         public Empleado Obtener(int Legajo)
         {
             foreach (Empleado em in Items)
             {
                 if (em.Legajo == Legajo)
                 {
                     return em;
                 }

             }
             // throw new Exception("Empleado no encontrado");
             return null;
         }*/
    }
}
