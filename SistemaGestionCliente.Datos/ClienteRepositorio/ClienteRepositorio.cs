using SistemaGestionCliente.Datos.ContextoPersistencia;
using SistemaGestionCliente.Entidades.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace SistemaGestionCliente.Datos.ClienteRepositorio
{
    public class ClienteRepositorio : RepositorioGenerico<Cliente>, IClienteRepositorio
    {
        public override void Eliminar(Cliente cliente)
        {
            using(var db = new ContextoDB())
            {
                var result = db.Clientes.Find(cliente.Cedula);
                result.Estado = false;
                db.SaveChanges();
            }
        }

        public bool ValidarCedula(string cedula)
        {
            using (var db = new ContextoDB())
            {
                var result = db.Clientes.Any(x => x.Cedula == cedula);
                return result;
            }
        }

        public override List<Cliente> ObtenerTodos()
        {
           using(var db = new ContextoDB())
            {
                return db.Clientes.Where(c => c.Estado == true).ToList();
            }
        }

        public Cliente BuscarClientePorId(string cedula)
        {
            using (var db = new ContextoDB())
            {
                var result =  db.Clientes.Include(x=>x.Zona)
                    .Include(x => x.Zona.Sector)
                    .Include(x => x.Zona.Sector.Ciudad)
                    .Include(x => x.Zona.Sector.Ciudad.Provincia)
                    .Where(c => c.Estado == true && c.Cedula == cedula);

                return result.FirstOrDefault();
            }
        }
    }
}
