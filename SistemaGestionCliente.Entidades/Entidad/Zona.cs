using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Entidades.Entidad
{
    public class Zona : Base
    {
        public string Nombre { get; set; }
        public int CodigoSectorFK { get; set; }

        #region Propiedad de Navegación
        public Sector Sector { get; set; }
        public ICollection<Cliente> Clientes{ get; set; }
        #endregion
    }
}
