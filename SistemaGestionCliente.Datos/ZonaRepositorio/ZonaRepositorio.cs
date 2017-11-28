using SistemaGestionCliente.Datos.ContextoPersistencia;
using SistemaGestionCliente.Entidades.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SistemaGestionCliente.Datos.ZonaRepositorio
{
    public class ZonaRepositorio : RepositorioGenerico<Zona>,IZonaRepositorio
    {
        public Zona BuscarZonaSectorCiudadProvincia(int codigoZona)
        {
            using (var db = new ContextoDB())
            {
                var result = db.Zonas
                    .Include(x => x.Sector)
                    .Include(x => x.Sector.Ciudad)
                    .Include(x => x.Sector.Ciudad.Provincia)
                    .Where(z=>z.Codigo == codigoZona);

                return result.FirstOrDefault();
            }
        }

        public override void Eliminar(Zona zona)
        {
            using(var db = new ContextoDB())
            {
                db.Zonas.Remove(zona);
                db.SaveChanges();
            }
        }
    }
}
