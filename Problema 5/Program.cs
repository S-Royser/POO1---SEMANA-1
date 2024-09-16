using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video vid = new Video(0010101, "Mas Rosque", 55, 20000, 50);

                Console.WriteLine("Datos actuales:");
                Video.Listado(vid);
                vid.PrecioSoles += 5.50;
                Console.WriteLine("Datos actualizados:");
                Video.Listado(vid);
        }
    }
}
