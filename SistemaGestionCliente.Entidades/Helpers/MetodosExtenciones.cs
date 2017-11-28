using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Entidades.Helpers
{
    public static class MetodosExtenciones
    {
        public static String FormatearCedula(this string valor)
        {
            if (valor.Count() < 11 && valor.Count() > 11) return valor;
            var cedFormateado = $"{valor.Substring(0, 3)}-{valor.Substring(3, 7)}-{valor.Substring(10, 1)}";
            return cedFormateado;
            
        }
    }
}
