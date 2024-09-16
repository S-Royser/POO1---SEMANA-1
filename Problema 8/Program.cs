using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor ase = new Asesor(010101, "Aranda", 30, 20);

                Console.WriteLine("Datos actuales: ");
                Asesor.Listado(ase);
                ase.HorasTrabajadas += 10;
                ase.PrecioHora -= ase.PrecioHora * 0.15;
                Asesor.Listado(ase);
        }
    }
}
