using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Direccion
    {
        public string  localidad { get; set; }

        public string codigoPostal { get; set; }

        public string calle { get; set; }

        public int altura { get; set; }
    }
}
