using SistemaGestionCliente.Entidades.VistaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.LogicaNegocio.ClienteServicios
{
    public interface IClienteServicios
    {
        bool ValidarCedula(string cedula);
        void Agregar(ClienteVM cliente);
        Task<List<ClienteVM>> ObtenerTodos();
        Task<ClienteVM> BuscarClientePorId(string cedula);
        void Eliminar(ClienteVM cliente);
        void Actualizar(ClienteVM cliente);
    }
}
