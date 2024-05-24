using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Deposito
    { 
        public Deposito() 
        {
            direccion = new Direccion();

            dueño = new Dueño();
        }
        public int cantPisos {  get; set; }

        public int mtsCuadrados { get; set; }

        public Direccion direccion { get; }

        public Dueño dueño { get; }

        public Empleado empleado { get; set; }

        public Pasillo pasillo { get; set; }


    }
}
