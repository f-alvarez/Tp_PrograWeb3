using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Repositorios
{
    public class RecetasRepository
    {
        public static List<Receta> Recetas = new List<Receta>();

        public void add(Receta receta)
        {
            receta.recetaId = Recetas.Count; //ESTO FUNCIONA SIEMPRE Y CUANDO NO SE ELIMINEN RECETAS
            Recetas.Add(receta);
        }

        public List<Receta> GetAllByUserId(int userId)
        {
            List<Receta> recetasByUser = new List<Receta>();

            foreach (Receta receta in Recetas)
            {
                if (receta.userId == userId)
                {
                    recetasByUser.Add(receta);
                }
            }
            return recetasByUser;

        }
    }
}
