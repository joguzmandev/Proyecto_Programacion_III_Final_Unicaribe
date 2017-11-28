using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Entidades.VistaModel
{
    public class ZonaVM
    {
        public int CodigoZona { get; set; }
        public string NombreZona { get; set; }
        public int CodigoSectorFK { get; set; }


        #region Propiedad Para detalles de la zona
        public string SectorMostrar { get; set; }
        public string CiudadMostrar { get; set; }
        public string ProvinciaMostrar { get; set; }
        #endregion
    }
}
