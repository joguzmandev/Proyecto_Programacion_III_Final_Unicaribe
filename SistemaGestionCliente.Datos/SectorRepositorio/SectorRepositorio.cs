using SistemaGestionCliente.Datos.ContextoPersistencia;
using SistemaGestionCliente.Entidades.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaGestionCliente.Datos.SectorRepositorio
{
    public class SectorRepositorio : RepositorioGenerico<Sector>, ISectorRepositorio
    {
      

        public override void Eliminar(Sector obj)
        {
            throw new NotImplementedException();
        }

        public Ciudad ObtenerCiudadProvincia(int idCiudad)
        {
            using(var db = new ContextoDB())
            {
                var result = db.Cuidades.Include(p => p.Provincia).FirstOrDefault(c => c.Codigo == idCiudad);
                return result;
            }
        }
    }
}
