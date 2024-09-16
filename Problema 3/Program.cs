using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio ed = new Edificio(010101, 20, 5, 100);

                Console.WriteLine("Datos actuales:");
                Edificio.Listado(ed);
                ed.PrecioDolaresDepartamento += 0.2 * ed.PrecioDolaresDepartamento;
                Console.WriteLine("Datos actualizados:");
                Edificio.Listado(ed);
        }
    }
}
