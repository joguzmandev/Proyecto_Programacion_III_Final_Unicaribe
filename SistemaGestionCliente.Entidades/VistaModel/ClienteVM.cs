using SistemaGestionCliente.Entidades.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Entidades.VistaModel
{
    public class ClienteVM
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

        #region Propiedad Para detalles del Cliente
        public string ZonaMostrar { get; set; }
        public string SectorMostrar { get; set; }
        public string CiudadMostrar { get; set; }
        public string ProvinciaMostrar { get; set; }
        #endregion
    }
}
