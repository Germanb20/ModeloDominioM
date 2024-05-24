using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    abstract class Persona
    {
        public Persona()
        {
            direccion = new Direccion();
        }
        public string nombre {  get; set; }
        public string apellido { get; set; }   
        public int dni {  get; set; }
        public string email { get; set; }
        public Direccion direccion {  get; }

    }
}
