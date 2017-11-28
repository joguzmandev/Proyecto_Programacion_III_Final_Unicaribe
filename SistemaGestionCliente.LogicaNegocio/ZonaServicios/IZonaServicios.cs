using SistemaGestionCliente.Entidades.VistaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.LogicaNegocio.ZonaServicios
{
    public interface IZonaServicios
    {
        Task Agregar(ZonaVM zona);
        Task<List<ZonaVM>> ObtenerToda();
        Task<ZonaVM> BuscarZonaSectorCiudadProvincia(int codigoZona);
    }
}
