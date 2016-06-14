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
        PW3_TP_20161CEntities contexto;

        public RecetasRepository(PW3_TP_20161CEntities context)
        {
            contexto = context;
        }

        public void add(Recetas receta)
        {
            contexto.Recetas.Add(receta);
            contexto.SaveChanges();
        }

        public List<Recetas> GetAllByUserId(int userId)
        {
            var usuario = (from e in contexto.Usuarios where e.IdUsuario == userId select e).FirstOrDefault();
            return usuario.Recetas.ToList();
        }
    }
}
