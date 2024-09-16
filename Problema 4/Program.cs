using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero obre = new Obrero(010101, "Elizabeth", 20, 30);

                Console.WriteLine("Datos actuales:");
                Obrero.Listado(obre);
                obre.HorasTrabajadas += 8;
                obre.TarifaHoras -= obre.HorasTrabajadas * 0.015;
                Console.WriteLine("Datos actualizados:");
                Obrero.Listado(obre);
        }
    }
}
