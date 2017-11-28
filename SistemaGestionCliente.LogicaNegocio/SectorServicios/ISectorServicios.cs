using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionCliente.Entidades.VistaModel;
namespace SistemaGestionCliente.LogicaNegocio.SectorServicios
{
    public interface ISectorServicios
    {
        Task<List<SectorVM>> ObtenerTodos();
        Task<CiudadVM> ObtenerCiudadProvincia(int idCiudad);
    }
}
