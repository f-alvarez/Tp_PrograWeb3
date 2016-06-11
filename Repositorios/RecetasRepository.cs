using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class RecetasRepository
    {
        public static List<Recetas> Recetas = new List<Recetas>();

        private static RecetasRepository RecetaRepo;

        private RecetasRepository() { }

        public static RecetasRepository getInstance
        {
            get 
            {
                if (RecetaRepo == null)
                {
                    RecetaRepo = new RecetasRepository();
                }
                return RecetaRepo;
            }
        }

        public void add(Recetas receta)
        {
            receta.IdReceta = Recetas.Count; //ESTO FUNCIONA SIEMPRE Y CUANDO NO SE ELIMINEN RECETAS
            Recetas.Add(receta);
        }

        public List<Recetas> GetAllByUserId(int userId)
        {
            List<Recetas> recetasByUser = new List<Recetas>();

            foreach (Recetas receta in Recetas)
            {
                if (receta.IdUsuario == userId)
                {
                    recetasByUser.Add(receta);
                }
            }
            return recetasByUser;

        }
    }
}
