using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Computadora
    {
        private int codigo;
        private string marca;
        private string color;
        private double precioDolares;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioDolares { get => precioDolares; set => precioDolares = value; }

        public Computadora(int codigo, string marca, string color, double precioDolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioDolares = precioDolares;
        }

        public double precioSoles()
        {
            return precioDolares * 3.35;
        }

        public double precioEuros()
        {
            return precioDolares / 1.20;
        }

        public static void Listado(Computadora c)
        {
            Console.WriteLine("Codigo: " + c.codigo);
            Console.WriteLine("Marca: " + c.marca);
            Console.WriteLine("Color: " + c.color);
            Console.WriteLine("Precio dolares: " + c.precioDolares);
            Console.WriteLine("Precio en Soles: " + c.precioSoles());
            Console.WriteLine("Precio en Euros: " + c.precioEuros() + "\n");
 
        }

    }
}
