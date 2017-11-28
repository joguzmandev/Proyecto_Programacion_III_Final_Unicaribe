using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Entidades.Entidad
{
    public class Sector : Base
    {
        public string Nombre { get; set; }
        public int CodigoCiudadFK { get; set; }

        #region Propiedad de Navegación
        public Ciudad Ciudad{ get; set; }
        public ICollection<Zona> Zonas { get; set; }
        #endregion
    }
}
