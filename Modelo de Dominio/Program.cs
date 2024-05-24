using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Empleado l1 = new Empleado();

            l1.direccion.localidad = "puerto banana";

            Console.WriteLine(l1.direccion.localidad);

            Console.ReadKey();

            



        }
    }
}
