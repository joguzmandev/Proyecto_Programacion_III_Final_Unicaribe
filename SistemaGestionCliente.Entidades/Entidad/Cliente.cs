using SistemaGestionCliente.Entidades.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Entidades.Entidad
{
    public class Cliente
    {
        public string Cedula { get; set; }//RNC O CEDULA
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public int CodigoZonaPK { get; set; }
        public bool Estado { get; set; } // 1 - ACTIVO || 2 - INACTIVO

        #region Propiedad de Navegación
        [ForeignKey("CodigoZonaPK")]
        public Zona Zona{ get; set; }
        #endregion

    }
}
