using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado em = new Empleado(0707707, "Royser", 919191991, 700);

                Console.WriteLine("Datos actuales: ");
                Empleado.Listado(em);
                em.NumeroCelular = 999888777;
                em.SueldoSoles += 200;
                Empleado.Listado(em);
        }
    }
}
