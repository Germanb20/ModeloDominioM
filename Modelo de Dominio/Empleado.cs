using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Empleado : Persona
    {
        public string puesto {  get; set; }
        public string sueldo { get; set; }
        public string horarioLaboral { get; set; }
        public string antiguedad {  get; set; } 

    }
}
