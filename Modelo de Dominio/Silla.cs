using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Silla : ProdMadera
    {
        public string color { get; set; }

        public string tipoMadera { get; set; }
    }
}
