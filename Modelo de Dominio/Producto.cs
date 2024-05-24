using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    abstract class Producto
    {
        public string categoria {  get; set; }

        public string marca { get; set; }

        public string modelo { get; set; }

        public int stock { get; set; }  

        public string volumen {  get; set; }

        public int peso { get; set; }

        public string precio { get; set; }
    }
}
