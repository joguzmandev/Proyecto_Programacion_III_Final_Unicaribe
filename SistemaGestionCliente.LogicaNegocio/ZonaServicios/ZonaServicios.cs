using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionCliente.Entidades.VistaModel;
using SistemaGestionCliente.Datos.ZonaRepositorio;
using SistemaGestionCliente.Entidades.Entidad;

namespace SistemaGestionCliente.LogicaNegocio.ZonaServicios
{
    public class ZonaServicios : IZonaServicios
    {
        private ZonaRepositorio _zonaRepo;
        public ZonaServicios()
        {
            _zonaRepo = new ZonaRepositorio();
        }
        public async Task Agregar(ZonaVM zona)
        {
            await Task.Run(() =>
            {
                _zonaRepo.Agregar(new Zona()
                {
                    Nombre = zona.NombreZona,
                    CodigoSectorFK = zona.CodigoSectorFK
                });
            });
        }

        public async Task<ZonaVM> BuscarZonaSectorCiudadProvincia(int codigoZona)
        {
            return await Task.Run( () =>
            {

                var result = _zonaRepo.BuscarZonaSectorCiudadProvincia(codigoZona);
                return new ZonaVM()
                {
                    NombreZona = result.Nombre,
                    SectorMostrar = result.Sector.Nombre,
                    CiudadMostrar = result.Sector.Ciudad.Nombre,
                    ProvinciaMostrar = result.Sector.Ciudad.Provincia.Nombre

                };
            });
        }

        public async Task<List<ZonaVM>> ObtenerToda()
        {
           return await Task.Run(() =>
            {
                var result = _zonaRepo.ObtenerTodos();
                return result.Select(c => new ZonaVM()
                {
                    CodigoZona = c.Codigo,
                    NombreZona = c.Nombre
                }).ToList();
            });
        }
    }
}
