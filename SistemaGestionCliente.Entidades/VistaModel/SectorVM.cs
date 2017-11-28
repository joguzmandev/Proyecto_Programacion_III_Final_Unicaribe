using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Entidades.VistaModel
{
    public class SectorVM
    {
        public int CodigoSector { get; set; }
        public string NombreSector { get; set; }
        public int CodigoCiudadFK { get; set; }
    }
}
