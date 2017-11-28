using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Entidades.VistaModel
{
    public class CiudadVM
    {
        public int CodigoCiudad { get; set; }
        public string NombreCiudad { get; set; }
        public int CodigoProvinciaFK { get; set; }
        public string NombreProvincia { get; set; }
    }
}
