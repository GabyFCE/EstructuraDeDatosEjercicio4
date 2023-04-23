using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatosEjercicio4
{
    internal class PersonaEnt
    {
        public long Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}

        public List<TelefonoEnt> Telefonos { get; set; }

        public bool ValidarPersona(out string error)
        {
            error = null;
            return true;
        }
    }
}
