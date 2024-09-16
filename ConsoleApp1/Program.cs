using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular cel = new Celular(999999999, 20, "Royser", 100);
          
                Console.WriteLine("Datos actuales:");
                Celular.Listado(cel);
                //Aumentar
                cel.Segundos_consumidos += 20;
                cel.Precio_segundo -= cel.Precio_segundo * 0.05;
                Console.WriteLine("Datos actualizados:");
                Celular.Listado(cel);
        }
    }
}
