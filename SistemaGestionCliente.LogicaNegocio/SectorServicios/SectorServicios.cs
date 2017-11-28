using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionCliente.Entidades.VistaModel;
using SistemaGestionCliente.Datos.SectorRepositorio;

namespace SistemaGestionCliente.LogicaNegocio.SectorServicios
{
    public class SectorServicios : ISectorServicios
    {
        private SectorRepositorio repo;
        public SectorServicios()
        {
            if (repo == null)
                repo = new SectorRepositorio();
        }
        public async Task<CiudadVM>  ObtenerCiudadProvincia(int idCiudad)
        {
            return await Task.Run(() => {

                var result = repo.ObtenerCiudadProvincia(idCiudad);
                return new CiudadVM()
                {
                    CodigoCiudad = result.Codigo,
                    NombreCiudad = result.Nombre,
                    CodigoProvinciaFK = result.CodigoProvinciaFK,
                    NombreProvincia = result.Provincia.Nombre
                };

            });
        }

        public async Task<List<SectorVM>> ObtenerTodos()
        {
           return await Task.Run(() =>
            {
                
                var result = repo.ObtenerTodos();

                return result.Select(x => new SectorVM()
                {
                    CodigoSector = x.Codigo,
                    NombreSector = x.Nombre,
                    CodigoCiudadFK = x.CodigoCiudadFK
                }).ToList();
            });
        }
    }
}
