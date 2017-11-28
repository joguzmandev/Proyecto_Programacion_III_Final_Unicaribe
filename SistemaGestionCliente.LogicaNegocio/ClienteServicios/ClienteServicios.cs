using SistemaGestionCliente.Datos.ClienteRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionCliente.Entidades.VistaModel;
using SistemaGestionCliente.Entidades.Entidad;
using System.Linq.Expressions;

namespace SistemaGestionCliente.LogicaNegocio.ClienteServicios
{
    public class ClienteServicios : IClienteServicios
    {
        private ClienteRepositorio _repo;
        public ClienteServicios()
        {
            this._repo = new ClienteRepositorio();
        }

        public void Agregar(ClienteVM cliente)
        {
            Cliente cl = new Cliente()
            {
                Cedula = cliente.Cedula,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Direccion = cliente.Direccion,
                Telefono = cliente.Telefono,
                Email = cliente.Email,
                Contacto = cliente.Contacto,
                TipoCliente = cliente.TipoCliente,
                CodigoZonaPK = cliente.CodigoZonaPK,
                Estado = true
            };
            _repo.Agregar(cl);
        }

        public async Task<ClienteVM> BuscarClientePorId(string cedula)
        {
            return await Task.Run(() =>
            {
                var result = _repo.BuscarClientePorId(cedula);

                return new ClienteVM()
                {
                    Nombre = result.Nombre,
                    Apellido = result.Apellido,
                    Cedula = result.Cedula,
                    Telefono = result.Telefono,
                    Email = result.Email,
                    Direccion = result.Direccion,
                    Contacto = result.Contacto,
                    TipoCliente = result.TipoCliente,
                    Estado = result.Estado,
                    ZonaMostrar = result.Zona.Nombre,
                    SectorMostrar = result.Zona.Sector.Nombre,
                    CiudadMostrar = result.Zona.Sector.Ciudad.Nombre,
                    ProvinciaMostrar = result.Zona.Sector.Ciudad.Provincia.Nombre,
                    CodigoZonaPK = result.CodigoZonaPK
                };

            });
        }

        public void Actualizar(ClienteVM cliente)
        {
            Cliente cl = new Cliente()
            {
                Cedula = cliente.Cedula,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Direccion = cliente.Direccion,
                Telefono = cliente.Telefono,
                Email = cliente.Email,
                Contacto = cliente.Contacto,
                TipoCliente = cliente.TipoCliente,
                CodigoZonaPK = cliente.CodigoZonaPK,
                Estado = true
            };
            _repo.Actualizar(cl);
        }

        public void Eliminar(ClienteVM cliente)
        {
            _repo.Eliminar(new Cliente() { Cedula = cliente.Cedula });
        }

        public async Task<List<ClienteVM>> ObtenerTodos()
        {
            return await Task.Run(() =>
            {
                var listaClientes = _repo.ObtenerTodos();
                
                return listaClientes.Select(c=>new ClienteVM() {
                    Cedula = c.Cedula,
                    Nombre = c.Nombre,
                    Apellido = c.Apellido,
                    Direccion = c.Direccion,
                    Telefono = c.Telefono,
                    Email = c.Email,
                    Contacto = c.Contacto,
                    TipoCliente =c.TipoCliente,
                    CodigoZonaPK = c.CodigoZonaPK,
                    Estado = c.Estado
                }).ToList();
            });
        }

        public bool ValidarCedula(string cedula)
        {
            return _repo.ValidarCedula(cedula);
        }
    }
}
