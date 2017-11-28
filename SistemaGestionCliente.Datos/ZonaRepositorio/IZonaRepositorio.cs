using SistemaGestionCliente.Datos;
using SistemaGestionCliente.Entidades.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Datos.ZonaRepositorio
{
    public interface IZonaRepositorio
    {
        Zona BuscarZonaSectorCiudadProvincia(int codigoZona);
    }
}
