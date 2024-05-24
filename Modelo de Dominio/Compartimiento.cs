using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Compartimiento
    {
        public int numero {  get; set; }

        public string productoAlmacenado { get; set; }

        public Producto producto {  get; set; }
    }
}
