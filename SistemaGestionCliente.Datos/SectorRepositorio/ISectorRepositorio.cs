using SistemaGestionCliente.Entidades.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Datos.SectorRepositorio
{
    public interface ISectorRepositorio 
    {
        Ciudad ObtenerCiudadProvincia(int idCiudad);
    }
}
