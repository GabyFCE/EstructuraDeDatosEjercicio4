using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosEjercicio4
{
    internal class TelefonoEnt
    {
        public string Tipo {get; set; }
        public int CodigoPais { get; set; }
        public int CodigoArea { get; set; }
        public long NumeroTelefono { get; set; }

        public bool ValidarTelefono(out string error)
        {
            if (Tipo != "CASA" && Tipo != "TRABAJO" && Tipo != "OTRO")
            {
                error = "Tipo de telefono inválido";
                return false;
            }

            error = null;
            return true;
        }
    }
}
