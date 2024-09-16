using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Celular
    {
        private int numero;
        private int segundos_consumidos;
        private string usuario;
        private double precio_segundo;

       

        public int Segundos_consumidos { get => segundos_consumidos; set => segundos_consumidos = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public double Precio_segundo { get => precio_segundo; set => precio_segundo = value; }
        public int Numero { get => numero; set => numero = value; }

        public Celular(int numero, int segundos_consumidos, string usuario, double precio_segundo)
        {
            this.numero = numero;
            this.segundos_consumidos = segundos_consumidos;
            this.usuario = usuario;
            this.precio_segundo = precio_segundo;
        }

        public double costoConsumo()
        {
            return Segundos_consumidos * Precio_segundo;
        }

        public double IGV()
        {
            return costoConsumo() * 0.18;
        }

        public double totalPagar()
        {
            return costoConsumo() + IGV();
        }

        public static void Listado(Celular c)
        {
            Console.WriteLine("Usuario: " + c.usuario);
            Console.WriteLine("Numero: " + c.Numero);
            Console.WriteLine("Segundos Consumidos: " + c.Segundos_consumidos);
            Console.WriteLine("Precio por segundo: " + c.Precio_segundo);
            Console.WriteLine("Costo por consumo: " + c.costoConsumo());
            Console.WriteLine("Impusto de IGV: " + c.IGV());
            Console.WriteLine("Total a pagar: " + c.totalPagar() + "\n" );
        }

      
    }


}
