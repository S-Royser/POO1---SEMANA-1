using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente pa = new Paciente("Patricio", "Parodi", 18, 1.65, 60);

                Console.WriteLine("Datos actuales:");
                Paciente.Listado(pa);
                pa.Edad = 15;
                Console.WriteLine("Datos actualizados:");
                Paciente.Listado(pa);
        }
    }
}
