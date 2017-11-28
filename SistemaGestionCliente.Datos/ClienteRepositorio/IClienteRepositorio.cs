using SistemaGestionCliente.Entidades.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Datos.ClienteRepositorio
{
    public interface IClienteRepositorio
    {
        bool ValidarCedula(string cedula);
        Cliente BuscarClientePorId(string cedula);
    }
}
