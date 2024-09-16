using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora com = new Computadora(010101, "Azus", "negro", 1000);
                Console.WriteLine("Datos actuales:");
                Computadora.Listado(com);
                com.PrecioDolares -= com.PrecioDolares * 0.1;
                Console.WriteLine("Datos actualizados:");
                Computadora.Listado(com);       
        }
    }
}
