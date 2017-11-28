using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaGestionCliente.Entidades.Entidad
{
    public class Ciudad : Base
    {
        
        public string Nombre { get; set; }
        public int CodigoProvinciaFK { get; set; }

        #region Propiedad de Navegación
        public Provincia Provincia { get; set; }

        public ICollection<Sector> Sectores{ get; set; }
        #endregion
    }
}
