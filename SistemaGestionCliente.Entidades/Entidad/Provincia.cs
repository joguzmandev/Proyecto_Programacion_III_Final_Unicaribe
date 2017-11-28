using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Entidades.Entidad
{
    public class Provincia : Base
    {
        public string Nombre { get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }

        public Provincia()
        {
            Ciudades = new List<Ciudad>();
        }
    }
}
