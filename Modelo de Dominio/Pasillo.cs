using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    abstract class Pasillo
    {
        public Pasillo()
        {
            compartimiento = new Compartimiento();
        }
        public int nroPasillo {  get; set; }

        public string ladoPasillo { get; set; }

        public int piso {  get; set; }

        public Compartimiento compartimiento { get; }


    }
}
