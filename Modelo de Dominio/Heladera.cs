using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Heladera : Electrodomestico
    {
        public string motor {  get; set; }

        public string medidas { get; set; }
    }
}
