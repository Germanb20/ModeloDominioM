using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Muebles : ProdMadera, Transportable
    {
        public string color {  get; set; }

        public string tipoMadera { get; set; }

        public string levantar()
        {
            return "Este producto debe ser transportado";
        }
    }
}
