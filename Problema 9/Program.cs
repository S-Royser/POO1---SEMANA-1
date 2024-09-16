using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pe = new Pelota("Adidas", 450, 15, 22, 80);

                Console.WriteLine("Datos actuales:");
                Pelota.Listado(pe);
                pe.Precio -= pe.Precio * 0.25;
                pe.DiametroCentimetros += 1;
                Pelota.Listado(pe);
        }
    }
}
