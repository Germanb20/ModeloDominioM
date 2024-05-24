using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Cafetera : Electrodomestico, Fragile
    {
        public string golpe()
        {
            return "Transportar con cuidado";
        }
    }
}
